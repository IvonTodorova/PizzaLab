using PizzaLab.Data.PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Services.Data
{
    public interface IPurchaseService
    {
        Task<Purchase> CreateAsync(Purchase product);

        Task<Purchase> UpdateAsync(Purchase product);

        Task<Purchase> GetPurchaseById(int id);
    }
}
