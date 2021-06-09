using PizzaLab.Data.PizzaLab.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Data.PizzaLab.Data.Models
{
    public class Product
    {
        public Product()
        {
            ProductsIngridients = new HashSet<ProductsIngridients>();
            MediaItems = new HashSet<MediaItem>();
        }

        private ICollection<ProductsIngridients> productsingridients;

        public virtual ICollection<ProductsIngridients> ProductsIngridients
        {
            get { return productsingridients; }
            private set { productsingridients = value; }
        }
        private ICollection<MediaItem> mediaItems;

        public virtual ICollection <MediaItem> MediaItems
        {
            get { return  mediaItems; }
            set {  mediaItems = value; }
        }
        public virtual ProductType ProductType { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }


    }
}
