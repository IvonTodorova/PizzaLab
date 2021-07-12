using PizzaLab.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;
using PizzaDotNet.Data.Models;
using PizzaLab.Web.ViewModels.Products;
using PizzaLab.Data.PizzaLab.Data.Models;

namespace PizzaLab.Web.ViewModels.Products
{
    public class ProductsCollectionViewModel : ProductViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
