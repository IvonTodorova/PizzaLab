using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaLab.Web.ViewModels.Cart
{
    using PizzaDotNet.Web.ViewModels.Cart;
    using PizzaLab.Data.PizzaLab.Data.Models;
    using PizzaLab.Services.Mapping;
    using PizzaLab.Web.ViewModels.Products;
    using System.Collections.Generic;
    using System.Linq;

    public class CartViewModel
    {
        public CartViewModel()
        {
            this.Products = new List<CartProductViewModel>();
        }

        public string UserId { get; set; }

        public List<CartProductViewModel> Products { get; set; }

        public decimal TotalPrice { get; set; }

        public CartAddressViewInputModel Address { get; set; }

        [Display(Name = "Additional notes:")]
        public string AdditionalNotes { get; set; }

        [Display(Name = "Use this as my default address")]
        public bool UseAddress { get; set; }
    }
}
