using PizzaLab.Data.Models;
using PizzaLab.Data.PizzaLab.Data.Models;
using PizzaLab.Data.PizzaLab.Data.Models.Enums;
using PizzaLab.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLab.Web.ViewModels.Purchases
{
    public class PurchaseViewModel : IMapFrom<Purchase>
    {
        public Dictionary<PizzaSize, decimal> sizes;
        private List<AddedProductIngredients> addedOptionalIngredients;

        public PurchaseViewModel()
        {
            this.sizes = new Dictionary<PizzaSize, decimal>();
            this.addedOptionalIngredients = new List<AddedProductIngredients>();
        }

        public virtual List<AddedProductIngredients> AddedOptionalIngredients
        {
            get { return this.addedOptionalIngredients; }
            set { this.addedOptionalIngredients = value; }
        }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public Dictionary<PizzaSize, decimal> Sizes { get { return this.sizes; } }

        public void PopulateSizesAndPrices()
        {
            this.Sizes.Add(PizzaSize.SMALL, this.Price);
            this.Sizes.Add(PizzaSize.MEDIUM, this.Price * 1.5M);
            this.Sizes.Add(PizzaSize.LARGE, this.Price * 2);
        }
    }
}
