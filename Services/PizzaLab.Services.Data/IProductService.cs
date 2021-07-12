using PizzaLab.Data.PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Services.Data
{
    public interface IProductService
    {
        Task<int> GetCount();

        Task<Product> CreateAsync(Product product);

        Task<Product> UpdateAsync(Product product);

        Task<bool> DeleteAsync(int productId);

        Task<T> GetById<T>(int id);

        Task<Product> GetBaseById(int id);

        Task<IEnumerable<T>> GetAll<T>(string sortCriteria = null, int? count = null);
    }
}
