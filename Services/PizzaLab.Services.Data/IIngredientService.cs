using PizzaLab.Data.PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Services.Data
{
    public interface IIngredientService
    {
        Ingrеdient GetIngredientById(int id);

        public void DischargeUnits(int unitsForDischage, int ingridientId);
        public void Update(Ingrеdient ingredient);
      
    }
}
