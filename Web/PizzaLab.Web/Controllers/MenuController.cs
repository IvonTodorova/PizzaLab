using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaLab.Data.PizzaLab.Data.Models;
using PizzaLab.Services.Data;
using PizzaLab.Web.ViewModels;
using PizzaLab.Web.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Web.Controllers
{
    public class MenuController : BaseController
    {
        private readonly IProductService productService;

        // private readonly IMapper mapper;
        public MenuController(IProductService productService)
        {
            this.productService = productService;
           // this.mapper = mapper;
        }

        public async Task<IActionResult> MenuAsync()
        {
            ProductsCollectionViewModel collection = new ProductsCollectionViewModel()
            {
                Products = await this.productService.GetAll<ProductViewModel>(),
            };

            return this.View(collection);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
