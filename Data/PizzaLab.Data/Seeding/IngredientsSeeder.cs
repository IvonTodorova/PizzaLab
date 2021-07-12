using PizzaLab.Data.EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLab.Data.Seeding
{
    public class IngredientsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Ingridients.Any())
            {
                return;
            }

            var ingredients = IngredientsData.GetIngredients();
            await dbContext.Ingridients.AddRangeAsync(ingredients);
        }
    }
}
