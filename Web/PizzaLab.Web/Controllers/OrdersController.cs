namespace PizzaLab.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using PizzaDotNet.Web.ViewModels.DTO;
    using PizzaLab.Common;
    using PizzaLab.Data.Models;
    using PizzaLab.Data.PizzaLab.Data.Models;
    using PizzaLab.Data.PizzaLab.Data.Models.Enums;
    using PizzaLab.Services;
    using PizzaLab.Services.Data;
    using PizzaLab.Web.ViewModels.Cart;
    using PizzaLab.Web.ViewModels.Orders;

    public class OrdersController : BaseController
    {
        private const string ACCESS_DENY_VIEW_ORDER = "You're not allowed to view this order";
        private const string ORDER_CANCELLED = "Your has been cancelled";
        private const string ORDER_CANT_CANCEL = "This order cannot be canceled";



     //   private readonly IEmailSender emailSender;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IMapper mapper;
        private readonly IUserAddressService userAddressService;
        private readonly IOrderService ordersService;
        private readonly ISessionService sessionService;
        private readonly IProductService productsService;
        private readonly IPurchaseService purchaseService;


        public OrdersController(
            IOrderService ordersService,
            ISessionService sessionService,
            IProductService productsService,
            UserManager<ApplicationUser> userManager,
            IMapper mapper,
            IUserAddressService userService)
        {
            this.ordersService = ordersService;
            this.sessionService = sessionService;
            this.productsService = productsService;
            this.userManager = userManager;
            this.mapper = mapper;
            this.userAddressService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> PlaceOrder(CartViewModel inputModel)
        {
            /* Get User */
            var user = await this.userManager.GetUserAsync(this.User);

            // var userAddres = await this.userService.UpdateAsync(user);
            if (user.UserAddress != null)
            {
                var userAddress = await this.userAddressService.GetUserAddressByApplicationUser(user.Id);

                /* Map from view model to model without losing data*/
                var newUserAddress = this.mapper.Map(inputModel.Address, userAddress);
                await this.userAddressService.UpdateAsync(newUserAddress);
            }
            else
            {
                var newUserAddress = this.mapper.Map<UserAddress>(inputModel.Address);
                newUserAddress.PhoneNumber = inputModel.Address.PhoneNumber;
             //   newUserAddress.ApplicationUserId = user.Id;

                await this.userAddressService.CreateAsync(newUserAddress);
            }

            /* Map order products */
            var cart = this.sessionService.Get<SessionCartDto>(this.HttpContext.Session, GlobalConstants.SessionCartKey);

            var purchases = new List<Purchase>();

            foreach (SessionCartProductDto productDto in cart.Products)
            {
                /* Create Purchase */
                var product = await this.productsService.GetBaseById(productDto.Id);

                Purchase purchase = new Purchase();

                Enum.TryParse(productDto.SizeName, out PizzaSize selectedPizzaSize);
                switch (selectedPizzaSize)
                {
                    case PizzaSize.SMALL:
                        purchase.TotalPrice = product.Price * productDto.Quantity;
                        break;
                    case PizzaSize.MEDIUM:
                        purchase.TotalPrice = (product.Price * 2) * productDto.Quantity;
                        break;
                    case PizzaSize.LARGE:
                        purchase.TotalPrice = (product.Price * 3) * productDto.Quantity;
                        break;
                }

                purchase.Product = product;
                purchase.Quantity = productDto.Quantity;
                purchase.PizzaSize = selectedPizzaSize;

                purchases.Add(purchase);
            }


            decimal orderTotalPrice = purchases.Select(p => p.TotalPrice).Sum();

            //TODO set DaTime of the order creation (use Datime.Now())
            //TODO calculate OrderTotalValue
            //TODO set AdditionaNoted to the correct Order property name
            var order = new Order()
            {
                User = user,
                Purchases = purchases,
                TotalPrice = orderTotalPrice,
                Note = inputModel.AdditionalNotes,
                DateTime = System.DateTime.UtcNow,
            };

            var orderEntity = this.ordersService.CreateAsync(order);

            /* Clear session */
            this.sessionService.Set(this.HttpContext.Session, GlobalConstants.SessionCartKey, new SessionCartDto());
            if (orderEntity.IsCompleted)
            {
                return this.RedirectToAction("View", new { orderId = orderEntity.Result.Id });
            }

            return this.RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> View (int orderId)
        {
            var userIsAdmin = this.User.IsInRole(GlobalConstants.AdministratorRoleName);
            var userId = this.userManager.GetUserId(this.User);

            var orderViewModel = await this.ordersService.GetById<OrderViewModel>(orderId);

            /* Prevent people (except admin) from viewing others orders */
            if (!userIsAdmin && userId != orderViewModel.UserId)
            {
                this.TempData["Message"] = ACCESS_DENY_VIEW_ORDER;
                this.TempData["MessageType"] = AlertMessageTypes.Error;
                return this.RedirectToAction("Index", "Home");
            }

            return this.View(orderViewModel);
        }

        public async Task<IActionResult> CancelOrder(int orderId)
        {
            var userIsAdmin = this.User.IsInRole(GlobalConstants.AdministratorRoleName);
            var userId = this.userManager.GetUserId(this.User);
            var order = await this.ordersService.GetById<Order>(orderId);

            /* Prevent people from cancelling others orders */
            if (!userIsAdmin&& userId!=order.User.Id)
            {
                this.TempData["Message"] = ACCESS_DENY_VIEW_ORDER;
                this.TempData["MessageType"] = AlertMessageTypes.Error;
                return this.RedirectToAction("Index", "Home");
            }

            return this.RedirectToAction("View", new { orderId });
        }
    }
}
