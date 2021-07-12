namespace PizzaDotNet.Web.ViewModels.Cart
{
    using System.ComponentModel.DataAnnotations;

    using PizzaDotNet.Data.Models;
    using PizzaLab.Data.PizzaLab.Data.Models;
    using PizzaLab.Services.Mapping;

    public class CartAddressViewInputModel : IMapFrom<UserAddress>
    {
        [Required]
        [Display(Name = "First name")]
        [MaxLength(20)]
        public string FistName { get; set; }

        public string ShippingAddress { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public long PhoneNumber { get; set; }

        //[Required]
        //public string Email { get; set; }

        public string Town { get; set; }

        public string Country { get; set; }
    }
}
