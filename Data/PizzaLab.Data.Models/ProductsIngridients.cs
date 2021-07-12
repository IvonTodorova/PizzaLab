using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Data.PizzaLab.Data.Models
{
    public class ProductsIngridients
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int IngridientId { get; set; }

        public Ingrеdient Ingridient { get; set; }

        public int DischargedUnits { get; set; }

        public bool IsOptionalForAddingAProduct { get; set; }
    }
}
