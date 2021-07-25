using PizzaLab.Data.PizzaLab.Data.Models;
using PizzaLab.Data.PizzaLab.Data.Models.Enums;
using PizzaLab.Services.Mapping;
using PizzaLab.Web.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PizzaLab.Web.ViewModels.Products
{
    public class ProductViewModel : IMapFrom<Product>
    {
        private ICollection<MediaItem> mediaItems;
        private Dictionary<PizzaSize, decimal> sizes;
        private ICollection<ProductsIngridients> productsingridients;
        private ICollection<Ingrеdient> optionalIngredients;
        private ICollection<Ingrеdient> addedPizzaIngredients;

        public ProductViewModel()
        {
            this.MediaItems = new HashSet<MediaItem>();
            this.sizes = new Dictionary<PizzaSize, decimal>();
            this.ProductsIngridients = new HashSet<ProductsIngridients>();
            this.OptionaIngredients = new HashSet<Ingrеdient>();
            this.addedPizzaIngredients = new HashSet<Ingrеdient>();
        }

        public virtual ICollection<Ingrеdient> AddedPizzaIngredients
        {
            get { return this.addedPizzaIngredients; }
            set { this.addedPizzaIngredients = value; }
        }
        public virtual ICollection<Ingrеdient> OptionaIngredients
        {
            get { return this.optionalIngredients; }
            set { this.optionalIngredients = value; }
        }

        public virtual ICollection<ProductsIngridients> ProductsIngridients
        {
            get { return this.productsingridients; }
            set { this.productsingridients = value; }
        }

        public virtual ICollection<MediaItem> MediaItems
        {
            get { return this.mediaItems; }
            set { this.mediaItems = value; }
        }

        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please select a valid size")]
        public string SizeName { get; set; }

        [Display(Name = "Quantity")]
        [Range(1, 20)]
        [Required(ErrorMessage = "Please enter a a valid quantity")]
        public int Quantity { get; set; }

        public string SelectedIngrеdientId { get; set; }

        public Dictionary<PizzaSize, decimal> Sizes { get { return this.sizes; } }

        public void PopulateSizesAndPrices()
        {
            this.Sizes.Add(PizzaSize.SMALL, this.Price);
            this.Sizes.Add(PizzaSize.MEDIUM, this.Price * 2);
            this.Sizes.Add(PizzaSize.LARGE, this.Price * 3);
        }
    }
}
