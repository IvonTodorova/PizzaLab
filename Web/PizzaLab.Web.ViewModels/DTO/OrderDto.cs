namespace PizzaLab.Web.ViewModels.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using PizzaLab.Data.Models;
    using PizzaLab.Data.PizzaLab.Data.Models;
    using PizzaLab.Services.Mapping;

    public class OrderDto : IMapFrom<Order>
    {
        private ICollection<Purchase> purchase;

        public virtual ICollection<Purchase> Purchases
        {
            get { return this.purchase; }
            set { this.purchase = value; }
        }

        [Key]
        public int Id { get; set; }

        public virtual ApplicationUser User { get; set; }

        public decimal OrderTotalValue { get; set; }

        public string Note { get; set; }

        public DateTime DateTime { get; set; }
    }
}
