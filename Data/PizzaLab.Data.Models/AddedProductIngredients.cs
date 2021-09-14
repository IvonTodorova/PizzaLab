using PizzaLab.Data.PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLab.Data.Models
{
   public class AddedProductIngredients
    {
        public int Id { get; set; }

        public int IngridientId { get; set; }

        public Ingrеdient Ingridient { get; set; }

        public int DischargedUnits { get; set; }
    }
}
