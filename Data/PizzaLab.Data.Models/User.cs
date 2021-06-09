using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Data.PizzaLab.Data.Models
{
    public class User
    {
        public User()
        {
           this.orders = new HashSet<Order>();
        }

        private ICollection<Order> orders;

        public virtual ICollection<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string FistName { get; set; }
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30)]
        public string ShippingAddress { get; set; }   
        [Required]
        [MaxLength(12)]
        [MinLength(10)]
        [Phone]
        public int PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        public string Town { get; set; }  
        public string Country { get; set; }
        public virtual ProductType UserType { get; set; }

    }
}
