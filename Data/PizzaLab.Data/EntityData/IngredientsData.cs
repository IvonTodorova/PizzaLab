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
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },
                new Ingrеdient()
                {
                    IngridientCategory= IngridientCategory.DOUGH,
                    Name="Whole-grain Dough",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=5,
                },
                new Ingrеdient()
                {
                    IngridientCategory= IngridientCategory.CHEESE,
                    Name="Mozzarella",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=5,
                },
                new Ingrеdient()
                {
                    IngridientCategory= IngridientCategory.CHEESE,
                    Name="Greek Cheese",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=5,
                },
                new Ingrеdient()
                {
                    IngridientCategory= IngridientCategory.CHEESE,
                    Name="Mortadella",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=5,
                },

                new Ingrеdient()
                {
                    IngridientCategory= IngridientCategory.SAUSE,
                    Name="Tomato",
                    MeasureType=Models.Enums.MeasureType.MILLILITRES,
                    UnitsInStock=200,
                    PricePerUnit=1,
                },

                new Ingrеdient()
                {
                    IngridientCategory= IngridientCategory.TOPPINGS,
                    Name="Pepperoni",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=5,
                },
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.TOPPINGS,
                    Name="Becon",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.TOPPINGS,
                    Name="Mushroom",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.TOPPINGS,
                    Name="Green Pepper",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.CHEESE,
                    Name="Provolone",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.CHEESE,
                    Name="Parmesan",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.DOUGH,
                    Name="Italian Dough",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.DOUGH,
                    Name="Italian Dough",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.TOPPINGS,
                    Name="Italian Salami",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.TOPPINGS,
                    Name="Italian Dough",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.TOPPINGS,
                    Name="Black Olives",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.TOPPINGS,
                    Name="Green Olives",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.CHEESE,
                    Name="White Bulgarian Cheese",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },
                new Ingrеdient()
                {
                    IngridientCategory = IngridientCategory.CHEESE,
                    Name="White Greek Cheese",
                    MeasureType=Models.Enums.MeasureType.GRAM,
                    UnitsInStock=200,
                    PricePerUnit=2,
                },

            };
            return ingredients;
        }
    }
}
