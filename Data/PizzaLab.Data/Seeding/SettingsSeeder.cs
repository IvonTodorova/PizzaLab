namespace PizzaLab.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using PizzaLab.Data.Models;

    internal class SettingsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Settings.Any())
            {
                return;
            }

            await dbContext.Settings.AddAsync(new Models.Setting { Name = "Setting1", Value = "value1" });
        }
    }
}
