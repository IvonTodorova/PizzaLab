using PizzaLab.Data.PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Web.ViewModels.DTO
{
    public class OrderDto
    {
       
        private ICollection<Purchase> purchase;

        public virtual ICollection<Purchase> Purchases
        {
            get { return purchase; }
            set { purchase = value; }
        }

        [Key]
        public int Id { get; set; }
        public virtual User User { get; set; }

        public decimal OrderTotalValue { get; set; }
        public string Note { get; set; }
        public DateTime DateTime { get; set; }
    }
}
