namespace PizzaLab.Services
{
    using AutoMapper;
    using PizzaDotNet.Web.ViewModels.Cart;
    using PizzaDotNet.Web.ViewModels.DTO;
    using PizzaLab.Data.Models;
    using PizzaLab.Data.PizzaLab.Data.Models;
    using PizzaLab.Web.ViewModels.Cart;
    using PizzaLab.Web.ViewModels.DTO;
    using PizzaLab.Web.ViewModels.Orders;
    using PizzaLab.Web.ViewModels.Products;
    using PizzaLab.Web.ViewModels.Purchases;

    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            /* ProductViewInputModel <--> SessionCartProductDto*/
            this.CreateMap<ProductViewModel, SessionCartProductDto>();
            this.CreateMap<SessionCartProductDto, ProductViewModel>();

            //this.CreateMap<ProductViewModel, ProductsIngridients>();
            //this.CreateMap<ProductsIngridients, ProductViewModel>();

            this.CreateMap<Product, ProductViewModel>();
            this.CreateMap<ProductViewModel, Product>();

            /* CartProductViewModel <--> SessionCartProductDto*/
            this.CreateMap<SessionCartProductDto, CartProductViewModel>();
            this.CreateMap<CartProductViewModel, SessionCartProductDto>();

            /* CartViewModel <--> SessionCartDto*/
            this.CreateMap<SessionCartDto, CartViewModel>();
            this.CreateMap<CartViewModel, SessionCartDto>();

            ///* UserAddress <--> AddressViewInputModel*/
            //this.CreateMap<AddressViewInputModel, UserAddress>();
            //this.CreateMap<UserAddress, AddressViewInputModel>();

            ///* OrderAddress <--> CartAddressViewInputModel*/
            //this.CreateMap<CartAddressViewInputModel, OrderAddress>();
            //this.CreateMap<OrderAddress, CartAddressViewInputModel>();

            /* UserAddress <--> CartAddressViewInputModel*/
            this.CreateMap<UserAddress, CartAddressViewInputModel>();
            this.CreateMap<CartAddressViewInputModel, UserAddress>();

            ///* OrderProduct <-> CartProductViewModel */
            this.CreateMap<Purchase, CartProductViewModel>();
            this.CreateMap<CartProductViewModel, Purchase>();

            ///* OrderProduct <-> SessionCartProductDto */
            this.CreateMap<Purchase, SessionCartProductDto>();
            this.CreateMap<SessionCartProductDto, Purchase>();

            ///* Product <-> OrderProduct */
            this.CreateMap<Product, Purchase>();
            this.CreateMap<Purchase, Product>();

            ///* Product <-> OrderProduct */
            this.CreateMap<Purchase, PurchaseViewModel>();
            this.CreateMap<PurchaseViewModel, Purchase>();

            ///* Order <-> OrderViewModel */
            this.CreateMap<Order, OrderViewModel>();
            this.CreateMap<OrderViewModel, Order>();

            ///* Order <-> OrderDto */
            this.CreateMap<Order, OrderDto>();
            this.CreateMap<OrderDto, Order>();


            this.CreateMap<ProductViewModel, CartProductViewModel>();
            this.CreateMap<CartProductViewModel, ProductViewModel>();

            //this.CreateMap<ProductViewModel,Cart>();
            //this.CreateMap<Cart,ProductViewModel>();

            //  this.CreateMap<Order, Order>();
            //this.CreateMap<Order, Order>();

            ///* OrderProduct <-> AdminOrderProductViewModel */
            //this.CreateMap<OrderProduct, AdminOrderProductViewModel>();
            //this.CreateMap<AdminOrderProductViewModel, OrderProduct>();

            ///* ImageModel */
            //this.CreateMap<AdminProductCreateInputModel, ImageUploadInputModel>();
            //this.CreateMap<AdminProductEditInputModel, ImageUploadInputModel>();
        }
    }
}
