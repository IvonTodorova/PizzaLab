using PizzaLab.Data.PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLab.Web.ViewModels.Products
{
    public class AddedOptionalIngredientViewModel
    {
        public int ProductId { get; set; }

        public int IngridientId { get; set; }

        public Ingrеdient Ingridient { get; set; }

        public int DischargedUnits { get; set; }
    }
}
