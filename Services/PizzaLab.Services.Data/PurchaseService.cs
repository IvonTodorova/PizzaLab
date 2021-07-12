using Microsoft.EntityFrameworkCore;
using PizzaLab.Data.Common.Repositories;
using PizzaLab.Data.PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Services.Data
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IRepository<Purchase> purchaseRepository;

        public PurchaseService(IRepository<Purchase> purchaseRepository)
        {
            this.purchaseRepository = purchaseRepository;
        }

        public async Task<Purchase> CreateAsync(Purchase purchase)
        {
            await this.purchaseRepository.AddAsync(purchase);
            this.purchaseRepository.SaveChanges();

            return purchase;
        }

        public async Task<Purchase> GetPurchaseById(int id)
        {
            var purchase = await this.purchaseRepository.All().FirstOrDefaultAsync(x => x.Id == id);

            return purchase;
        }

        public async Task<Purchase> UpdateAsync(Purchase purchase)
        {
            await this.purchaseRepository.AddAsync(purchase);

            await this.purchaseRepository.SaveChangesAsync();

            return purchase;
        }
    }
}
