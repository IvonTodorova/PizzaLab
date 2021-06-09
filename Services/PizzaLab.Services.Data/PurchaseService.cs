using PizzaLab.Data.Common.Repositories;
using PizzaLab.Data.PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Services.Data
{
    public class PurchaseService:IPurchaseService
    {
        private readonly IRepository<Purchase> purchaseRepository;
        public PurchaseService(IRepository<Purchase> purchaseRepository)
        {
            this.purchaseRepository = purchaseRepository;
        }

    }
}
