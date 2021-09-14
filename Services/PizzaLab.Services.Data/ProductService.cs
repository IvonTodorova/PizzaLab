using Microsoft.EntityFrameworkCore;
using PizzaLab.Data.Common.Repositories;
using PizzaLab.Data.PizzaLab.Data.Models;
using PizzaLab.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Services.Data
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> productsRepository;

        public ProductService(IRepository<Product> productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            await this.productsRepository.AddAsync(product);
            await this.productsRepository.SaveChangesAsync();

            return product;
        }

        public async Task<bool> DeleteAsync(int productId)
        {
            var product = await this.productsRepository.All().FirstOrDefaultAsync(x => x.Id == productId);
            this.productsRepository.Delete(product);
            var result = await this.productsRepository.SaveChangesAsync();

            return result > 0;
        }

        public async Task<IEnumerable<T>> GetAll<T>(string sortCriteria = null, int? count = null)
        {
            var productsQuery = this.productsRepository.All();

            if (typeof(T) == typeof(Product))
            {
                var products = productsQuery.ToList<Product>();
                return products as IEnumerable<T>;
            }

            var result = await productsQuery.To<T>().ToListAsync();

            return result;
        }

        public async Task<Product> GetBaseById(int id)
        {
            var product = await this.productsRepository.All().Where(x => x.Id == id).Include(x => x.ProductsIngridients).FirstOrDefaultAsync();

            return product;
        }

        public async Task<T> GetById<T>(int id)
        {

            var product = await this.productsRepository
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefaultAsync();

            return product;
        }

        public async Task<int> GetCount()
        {
            int count = this.productsRepository.All().Count();

            return count;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            this.productsRepository.Update(product);
            await this.productsRepository.SaveChangesAsync();

            return product;

        }
    }
}
