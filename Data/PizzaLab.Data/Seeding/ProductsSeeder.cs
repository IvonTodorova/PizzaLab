using PizzaLab.Data.EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLab.Data.Seeding
{
    public class ProductsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Products.Any())
            {
                return;
            }

            var productsData = ProductsData.GetPizzas();
            await dbContext.Products.AddRangeAsync(productsData);
        }
    }
}
