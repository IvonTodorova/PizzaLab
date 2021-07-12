using PizzaLab.Data.Common.Repositories;
using PizzaLab.Data.PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLab.Services.Data
{
    public interface IProductIngredientService
    {

        public IEnumerable<ProductsIngridients> GetAllProductIngredientsByProductId(int productId);

        public IEnumerable<ProductsIngridients> GetAllOptionalIngredient();
    }
}
