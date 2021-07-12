namespace PizzaLab.Web.ViewModels.Cart
{
    using System;
    using System.Collections.Generic;
    using PizzaLab.Data.PizzaLab.Data.Models;
    using PizzaLab.Data.PizzaLab.Data.Models.Enums;
    using PizzaLab.Services.Mapping;
    using PizzaLab.Web.ViewModels.Products;

    public class CartProductViewModel : IMapFrom<Product>
    {
        private ICollection<MediaItem> mediaItems;
        public ICollection<ProductsIngridients> productsingridients;

        public CartProductViewModel()
        {
            this.MediaItems = new HashSet<MediaItem>();
            this.productsingridients = new HashSet<ProductsIngridients>();

        }
        public virtual ICollection<ProductsIngridients> ProductsIngridients
        {
            get { return this.productsingridients; }
            set { this.productsingridients = value; }
        }

        public string SizeName { get; set; }

        public virtual ICollection<MediaItem> MediaItems
        {
            get { return this.mediaItems; }
            set { this.mediaItems = value; }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }

        public string ImageUrl { get; set; }
    }
}
