using PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaLab.Data.PizzaLab.Data.Models
{
    public class Order
    {
        public Order()
        {
            this.purchase = new HashSet<Purchase>();
        }

        private ICollection<Purchase> purchase;

        public virtual ICollection<Purchase> Purchases
        {
            get { return this.purchase; }
            set { this.purchase = value; }
        }

        [Key]
        public int Id { get; set; }

        public virtual ApplicationUser User { get; set; }

        public decimal TotalPrice { get; set; }

        public string Note { get; set; }

        public DateTime DateTime { get; set; }
    }
}
