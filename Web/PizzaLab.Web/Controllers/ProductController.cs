using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PizzaDotNet.Web.ViewModels.DTO;
using PizzaLab.Common;
using PizzaLab.Data.Models;
using PizzaLab.Data.PizzaLab.Data.Models;
using PizzaLab.Services;
using PizzaLab.Services.Data;
using PizzaLab.Web.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PizzaLab.Web.Controllers
{
    public class ProductController : BaseController
    {
        private const string CART_ADD_PRODUCT = "Product added to cart";
        private const string CART_REMOVE_PRODUCT = "Product removed from cart";
        private const string CART_INVALID_ITEM = "Invalid item";

        private readonly IProductService productsService;
        private readonly IMapper mapper;
        private readonly IProductIngredientService productIngredientRepo;
        private readonly IIngredientService ingredientsService;
        private readonly ISessionService sessionService;

        public ProductController(
            IProductService productService,
            IMapper mapper,
            IIngredientService ingredientsService,
            IProductIngredientService productIngredientRepo,
            ISessionService sessionService)
        {
            this.productsService = productService;
            this.mapper = mapper;
            this.ingredientsService = ingredientsService;
            this.productIngredientRepo = productIngredientRepo;
            this.sessionService = sessionService;
        }

        [Route("[controller]/{id}")]
        public async Task<IActionResult> Product(int id)
        {
            var productViewModel = await this.productsService.GetById<ProductViewModel>(id);
            productViewModel.PopulateSizesAndPrices();


            //optionalIngredients
            List<ProductsIngridients> productIngridientsOptional = this.productIngredientRepo.GetAllOptionalIngredient().ToList();

            //add optional ingredients to product view model
            productViewModel.AddedOptionalIngredients = new List<AddedProductIngredients>();


            foreach (var productIngridientOptional in productIngridientsOptional)
            {
                //add optional ingredients in the product view model and get the ingredient by id 
                var ingredient = this.ingredientsService.GetIngredientById(productIngridientOptional.IngridientId);

                AddedProductIngredients optionalIngredient = new AddedProductIngredients()
                {
                    DischargedUnits = 0,
                    IngridientId = ingredient.Id,
                    Ingridient = ingredient,
                };


                productViewModel.AddedOptionalIngredients.Add(optionalIngredient);
            }

            //add ingredient for the list ot ingredients in the product
            //foreach (var productIngredient in productViewModel.ProductsIngridients)
            //{
            //    productIngredient.Ingridient = this.ingredientsService.GetIngredientById(productIngredient.IngridientId);
            //}

            if (productViewModel == null)
            {
                return this.NotFound();
            }

            return this.View(productViewModel);
        }
    }
}
