using PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaLab.Data.PizzaLab.Data.Models
{
    public class UserAddress
    {
       [Key]
        public int UserAddressId { get; set; }

        public string FistName { get; set; }
 
        public string ShippingAddress { get; set; }

        public long PhoneNumber { get; set; }
        public string Town { get; set; }

        public string Country { get; set; }

        public virtual ProductType UserType { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
