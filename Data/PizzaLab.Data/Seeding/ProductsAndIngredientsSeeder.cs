namespace PizzaLab.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore.Internal;

    internal class ProductsAndIngredientsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Products.Any())
            {
                return;
            }

            var productsAndIngredientsData = EntityData.ProductsData.GetPizzas();
            await dbContext.Products.AddRangeAsync(productsAndIngredientsData);
        }
    }
}
