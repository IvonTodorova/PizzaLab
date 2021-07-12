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
using PizzaLab.Web.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Web.Controllers
{
    public class CartController : Controller
    {
        private const string CART_ADD_PRODUCT = "Product added to cart";
        private const string CART_REMOVE_PRODUCT = "Product removed from cart";
        private const string CART_INVALID_ITEM = "Invalid item";

        private readonly IProductService productsService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ISessionService sessionService;
        private readonly IMapper mapper;

        public CartController(
            IProductService productsService,
            UserManager<ApplicationUser> userManager,
            ISessionService sessionService,
            IMapper mapper)
        {
            this.productsService = productsService;
            this.userManager = userManager;
            this.sessionService = sessionService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> CartAsync()
        {
            var cart = this.sessionService.Get<SessionCartDto>(this.HttpContext.Session, GlobalConstants.SessionCartKey);

            if (cart == null)
            {
                this.sessionService.Set(
                    this.HttpContext.Session,
                    GlobalConstants.SessionCartKey,
                    new SessionCartDto());

                cart = this.sessionService.Get<SessionCartDto>(this.HttpContext.Session, GlobalConstants.SessionCartKey);
            }

            var cartViewModel = this.mapper.Map<CartViewModel>(cart);

            var productsViewModels = new List<CartProductViewModel>();

            foreach (SessionCartProductDto productDto in cart.Products)
            {
                //* Create view model */ 
                var productViewModel = await this.productsService.GetById<CartProductViewModel>(productDto.Id);
                foreach (var productIngridient in productViewModel.ProductsIngridients)
                {

                    /* Get product size */
                    Enum.TryParse(productDto.SizeName, out PizzaSize selectedPizzaSize);
                    switch (selectedPizzaSize)
                    {
                        case PizzaSize.SMALL:
                            productViewModel.TotalPrice = productViewModel.Price;
                            break;
                        case PizzaSize.MEDIUM:
                            productViewModel.TotalPrice = (productViewModel.Price * 2);
                            break;
                        case PizzaSize.LARGE:
                            productViewModel.TotalPrice = (productViewModel.Price * 3);
                            break;
                    }

                    /* Map data (Quantity, Size) from Product DTO */
                    productViewModel = this.mapper.Map(productDto, productViewModel);

                    productsViewModels.Add(productViewModel);
                }
            }

            /* Update the Products View Models in the Cart View Model */
            cartViewModel.Products = productsViewModels;

            return this.View(cartViewModel);
        }

        [HttpGet]
        public IActionResult AddItem()
        {
            return this.RedirectToAction("Cart");
        }

        [HttpPost]
        public IActionResult AddItem(ProductViewModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
               this.TempData["Message"] = CART_INVALID_ITEM;
               this.TempData["MessageType"] = AlertMessageTypes.Error;

               return this.RedirectToAction("View", $"Products", new { id = inputModel.Id });
            }

            var cart = new SessionCartDto();

            if (this.sessionService.TryGet(this.HttpContext.Session, GlobalConstants.SessionCartKey))
            {
                cart = this.sessionService.Get<SessionCartDto>(this.HttpContext.Session, GlobalConstants.SessionCartKey);
            }

            //Map session and the product from the menu 
            var cartProductModel = this.mapper.Map<SessionCartProductDto>(inputModel);
            //add the product to the cart
            cart.Products.Add(cartProductModel);
            //add products
            this.sessionService.Set(this.HttpContext.Session, GlobalConstants.SessionCartKey, cart);


            this.TempData["Message"] = CART_ADD_PRODUCT;
            this.TempData["MessageType"] = AlertMessageTypes.Success;
            return this.RedirectToAction("Cart");
        }

        public IActionResult RemoveItem(int itemId)
        {
            var cart = this.sessionService.Get<SessionCartDto>(this.HttpContext.Session, GlobalConstants.SessionCartKey);

            cart.Products.RemoveAll(x => x.Id == itemId);
            this.sessionService.Set(this.HttpContext.Session, GlobalConstants.SessionCartKey, cart);

            this.TempData["Message"] = CART_REMOVE_PRODUCT;
            this.TempData["MessageType"] = AlertMessageTypes.Success;

            return this.RedirectToAction("Cart");
        }

        public IActionResult IncreaseItemQuantity(int itemId)
        {
            var cart = this.sessionService.Get<SessionCartDto>(this.HttpContext.Session, GlobalConstants.SessionCartKey);

            cart.Products.FindAll(x => x.Id == itemId && x.Quantity < 10).ForEach(x => x.Quantity++);

            this.sessionService.Set(this.HttpContext.Session, GlobalConstants.SessionCartKey, cart);

            return this.RedirectToAction("Cart");
        }

        public IActionResult DecreaseItemQuantity(int itemId)
        {
            var cart = this.sessionService.Get<SessionCartDto>(this.HttpContext.Session, GlobalConstants.SessionCartKey);

            cart.Products.FindAll(x => x.Id == itemId && x.Quantity > 1).ForEach(x => x.Quantity--);

            this.sessionService.Set(this.HttpContext.Session, GlobalConstants.SessionCartKey, cart);

            return this.RedirectToAction("Cart");
        }
    }
}
