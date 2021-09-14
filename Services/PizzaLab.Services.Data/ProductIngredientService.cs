using PizzaLab.Data.Common.Repositories;
using PizzaLab.Data.PizzaLab.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaLab.Services.Data
{
    public class ProductIngredientService : IProductIngredientService
    {
        private readonly IRepository<ProductsIngridients> productIngredientRepository;

        public ProductIngredientService(IRepository<ProductsIngridients> productIngredientRepository)
        {
            this.productIngredientRepository = productIngredientRepository;
        }


        public IEnumerable<ProductsIngridients> GetAllProductIngredientsByProductId(int productId)
        {
            var ingredientsByProductId = this.productIngredientRepository.All().Where(x => x.ProductId == productId).ToList();

            return ingredientsByProductId;
        }

        public IEnumerable<ProductsIngridients> GetAllOptionalIngredient()
        {
            var optionalIngredients = this.productIngredientRepository.All().Where(x => x.IsOptionalForAddingAProduct == true).ToList();

            var optionalDistinct = optionalIngredients.Distinct(new ProductIngredientsComparer());
            return optionalDistinct;
        }



    }
}
