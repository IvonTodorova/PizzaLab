using PizzaLab.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;
using PizzaLab.Data.Models;
using PizzaLab.Data.PizzaLab.Data.Models;
using PizzaLab.Web.ViewModels.Purchases;

namespace PizzaLab.Web.ViewModels.Orders
{

    public class OrderViewModel : IMapFrom<Order>
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public ICollection<PurchaseViewModel> Purchases { get; set; }

        public decimal? TotalPrice { get; set; }

        public bool IsDeletedOrder { get; set; }

    }
}
