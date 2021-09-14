using PizzaLab.Data.Common.Models;
using PizzaLab.Data.Models;
using PizzaLab.Data.PizzaLab.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Data.PizzaLab.Data.Models
{
    public class Product:BaseDeletableModel<int>
    {
        private List<AddedProductIngredients> addedOptionalIngredients;
        private ICollection<ProductsIngridients> productsingridients;
        private ICollection<MediaItem> mediaItems;

        public Product()
        {
            this.ProductsIngridients = new HashSet<ProductsIngridients>();
            this.MediaItems = new HashSet<MediaItem>();
            this.addedOptionalIngredients = new List<AddedProductIngredients>();
        }

        public virtual ICollection<ProductsIngridients> ProductsIngridients
        {
            get { return this.productsingridients; }
            set { this.productsingridients = value; }
        }

        public virtual ICollection <MediaItem> MediaItems
        {
            get { return this.mediaItems; }
            set { this.mediaItems = value; }
        }

        public virtual List<AddedProductIngredients> AddedOptionalIngredients
        {
            get { return this.addedOptionalIngredients; }
            set { this.addedOptionalIngredients = value; }
        }
        public virtual ProductType ProductType { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
