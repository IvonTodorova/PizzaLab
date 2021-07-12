using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PizzaLab.Data.PizzaLab.Data.Models;
using PizzaLab.Services.Data;
using PizzaLab.Web.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService productsService;
        private readonly IMapper mapper;
        private readonly IProductIngredientService productIngredientRepo;
        private readonly IIngredientService ingredientsService;

        public ProductController(
            IProductService productService,
            IMapper mapper,
            IIngredientService ingredientsService,
            IProductIngredientService productIngredientRepo)
        {
            this.productsService = productService;
            this.mapper = mapper;
            this.ingredientsService = ingredientsService;
            this.productIngredientRepo = productIngredientRepo;
        }

        [Route("[controller]/{id}")]
        public async Task<IActionResult> Product(int id)
        {
            var productViewModel = await this.productsService.GetById<ProductViewModel>(id);
            productViewModel.PopulateSizesAndPrices();

            //optionalIngredients
            List<ProductsIngridients> productIngridientsOptional = this.productIngredientRepo.GetAllOptionalIngredient().ToList();
            //add optional ingredients to product view model
            productViewModel.OptionaIngredients = new List<Ingrеdient>();

            foreach (var productIngridientOptional in productIngridientsOptional)
            {
                //add optional ingredients in the product view model and get the ingredient by id 
                var optionalIngredient = this.ingredientsService.GetIngredientById(productIngridientOptional.IngridientId);
                productViewModel.OptionaIngredients.Add(optionalIngredient);
            }
            //add ingredient
            foreach (var productIngredient in productViewModel.ProductsIngridients)
            {
                productIngredient.Ingridient = this.ingredientsService.GetIngredientById(productIngredient.IngridientId);
            }

            if (productViewModel == null)
            {
                return this.NotFound();
            }

            return this.View(productViewModel);
        }
    }
}
