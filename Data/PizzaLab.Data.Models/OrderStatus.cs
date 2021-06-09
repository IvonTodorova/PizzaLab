namespace PizzaDotNet.Data.Models
{
    using System.Collections.Generic;
    using PizzaLab.Data.PizzaLab.Data.Models;

    public class OrderStatus 
    {
        public OrderStatus()
        {
            this.Orders = new HashSet<Order>();
        }

        public string Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
