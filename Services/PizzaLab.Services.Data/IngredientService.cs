using Microsoft.EntityFrameworkCore;
using PizzaLab.Data.Common.Repositories;
using PizzaLab.Data.PizzaLab.Data.Models;
using PizzaLab.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLab.Services.Data
{
    public class IngredientService : IIngredientService
    {
        private readonly IRepository<Ingrеdient> ingredientRepository;

        public IngredientService(IRepository<Ingrеdient> ingredientRepository)
        {
            this.ingredientRepository = ingredientRepository;
        }

        public Ingrеdient GetIngredientById(int id)
        {
            var idIngredient = this.ingredientRepository.All().Where(x => x.Id == id).FirstOrDefault();

            return idIngredient;
        }

        public void DischargeUnits(int unitsForDischage, int ingridientId)
        {
            var ingredients = this.ingredientRepository.All().Where(x => x.Id == ingridientId && x.UnitsInStock > 0);

            foreach (var item in ingredients)
            {
                item.UnitsInStock -= unitsForDischage;
            }

            this.ingredientRepository.SaveChanges();
        }


       


    }
}
