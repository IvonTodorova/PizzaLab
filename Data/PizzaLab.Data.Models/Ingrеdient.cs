using PizzaLab.Data.PizzaLab.Data.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaLab.Data.PizzaLab.Data.Models
{
    public class Ingrеdient
    {
        public Ingrеdient()
        {
            this.ProductsIngridients = new HashSet<ProductsIngridients>();
        }

        public ICollection<ProductsIngridients> ProductsIngridients { get; set; }

        public virtual IngridientCategory IngridientCategory { get; set; }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal PricePer100Grams { get; set; }

    }
}