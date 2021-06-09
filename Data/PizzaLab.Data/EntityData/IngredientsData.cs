using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaLab.Data.PizzaLab.Data.Models;
using PizzaLab.Data.PizzaLab.Data.Models.Enums;

namespace PizzaLab.Data.EntityData
{
    public class IngredientsData
    {
        public static ICollection<Ingrеdient> GetIngredients()
        {
            var ingredients = new List<Ingrеdient>()
            {
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.DOUGH,
                    Name="Italian Dough",
                    PricePer100Grams=1,
                },
                new Ingrеdient()
                { 
                    IngridientCategory= IngridientCategory.DOUGH,
                    Name="Whole-grain Dough",
                    PricePer100Grams=1,
                },
                new Ingrеdient()
                {
                    IngridientCategory= IngridientCategory.CHEESE,
                    Name="Mozzarella",
                    PricePer100Grams=2,
                },
                 new Ingrеdient()
                {
                    IngridientCategory= IngridientCategory.CHEESE,
                    Name="Greek Cheese",
                    PricePer100Grams=2,
                },
                    new Ingrеdient()
                {
                    IngridientCategory= IngridientCategory.CHEESE,
                    Name="Mortadella",
                    PricePer100Grams=2,
                },

                 new Ingrеdient()
                {
                    IngridientCategory= IngridientCategory.SAUSE,
                    Name="Tomato",
                    PricePer100Grams=2,
                },

                new Ingrеdient()
                {
                    IngridientCategory= IngridientCategory.TOPPINGS,
                    Name="Pepperoni",
                    PricePer100Grams=3,
                },

            };
            return ingredients;
        }
    }
}
