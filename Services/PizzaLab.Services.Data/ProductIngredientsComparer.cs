using PizzaLab.Data.PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Services.Data
{
    public class ProductIngredientsComparer : IEqualityComparer<ProductsIngridients>
    {
        public bool Equals(ProductsIngridients x, ProductsIngridients y)
        {
            if (x.IngridientId == y.IngridientId )
            {
                return true;
            }

            return false;
        }

        public int GetHashCode(ProductsIngridients obj)
        {
            return obj.IngridientId.GetHashCode();
        }
    }
}
