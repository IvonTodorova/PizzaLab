using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PizzaDotNet.Web.ViewModels.DTO;
using PizzaLab.Common;
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
            productViewModel.OptionaIngredients = new List<Ingrеdient>();
            var addedPizzaIngredientsBuffAsString = TempData["AddedPizzaIngredients"];
            if (addedPizzaIngredientsBuffAsString != null )
            {
                List<Ingrеdient> addedPizzaIngredientsBuff = JsonSerializer.Deserialize<List<Ingrеdient>>(addedPizzaIngredientsBuffAsString.ToString());
                productViewModel.AddedPizzaIngredients = addedPizzaIngredientsBuff;
            }
            else
            {
                productViewModel.AddedPizzaIngredients = new List<Ingrеdient>();
            }

            foreach (var productIngridientOptional in productIngridientsOptional)
            {
                //add optional ingredients in the product view model and get the ingredient by id 
                var optionalIngredient = this.ingredientsService.GetIngredientById(productIngridientOptional.IngridientId);
                productViewModel.OptionaIngredients.Add(optionalIngredient);

                //var add = GetAddedIngredient(optionalIngredient);

                //productViewModel.AddedPizzaIngredients.Add(add);
            }

            //add ingredient for the list ot ingredients in the product
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

        [Route("[controller]/AddOptionalIngredient")]
        public IActionResult AddOptionalIngredient(ProductViewModel productViewItem)
        {
            int id = int.Parse(productViewItem.SelectedIngrеdientId);
            var selectedIgredient = this.ingredientsService.GetIngredientById(id);
            productViewItem.AddedPizzaIngredients.Add(selectedIgredient);
            TempData["AddedPizzaIngredients"] = JsonSerializer.Serialize(productViewItem.AddedPizzaIngredients);
            return this.RedirectToAction("Product", new { id = productViewItem.Id });
        }

        public IActionResult DecreaseItemQuantity(int itemId)
        {
            var cart = this.sessionService.Get<SessionCartDto>(this.HttpContext.Session, GlobalConstants.SessionCartKey);

            cart.Products.FindAll(x => x.Id == itemId && x.Quantity > 1).ForEach(x => x.Quantity--);

            this.sessionService.Set(this.HttpContext.Session, GlobalConstants.SessionCartKey, cart);

            return this.RedirectToAction("Cart");
        }



        //public Ingrеdient GetAddedIngredient(Ingrеdient ingredient)
        //{
        //    var getingredientbyId = this.ingredientsService.GetIngredientById(ingredient.Id);

        //    if (getingredientbyId.UnitsInStock>0)
        //    {
        //        getingredientbyId.UnitsInStock--;
        //        this.ingredientsService.Update(ingredient);
        //    }

        //    return getingredientbyId;
        //}
    }
}
