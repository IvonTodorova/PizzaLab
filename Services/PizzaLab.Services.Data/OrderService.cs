using Microsoft.EntityFrameworkCore;
using PizzaLab.Data;
using PizzaLab.Data.Common.Repositories;
using PizzaLab.Data.PizzaLab.Data.Models;

using PizzaLab.Services.Mapping;
using PizzaLab.Web.ViewModels.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Services.Data
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> orderRepository;
        private readonly IIngredientService ingrеdienttRepo;
        private readonly IPurchaseService purchaseRepository;
        private readonly IProductIngredientService productIngredientService;

        public OrderService(IRepository<Order> orderRepository, IPurchaseService purchaseRepository, IIngredientService ingrеdienttRepo, IProductIngredientService productIngredientService)
        {
            this.orderRepository = orderRepository;
            this.purchaseRepository = purchaseRepository;
            this.ingrеdienttRepo = ingrеdienttRepo;
            this.productIngredientService = productIngredientService;
        }

        public async Task<Order> CreateAsync(Order order)
        {
            List<Purchase> purchasesForAdd = order.Purchases.ToList();

            order.Purchases = new List<Purchase>();

            await this.orderRepository.AddAsync(order);
            this.orderRepository.SaveChanges();

            foreach (var purchase in purchasesForAdd)
            {
                //TODO get product ingredients by product id
                var productIngredients = this.productIngredientService.GetAllProductIngredientsByProductId(purchase.Product.Id);

                //ingridientite koito sa v produkta shte namalqme
                foreach (var productIngridient in productIngredients)
                {
                    //namalqme ingridienta v pizzata
                    var unitsForDischage = productIngridient.DischargedUnits * purchase.Quantity;

                    //TODO DISCHARGE UNIQUE Collection INGREDIENTS FOR EVERY PRODUCT

                    this.ingrеdienttRepo.DischargeUnits(unitsForDischage, productIngridient.IngridientId);
                }

                purchase.Order = order;

                //TODO save to db PURCHASES (CREATE A RECORD)
                var savePurchase = this.purchaseRepository.CreateAsync(purchase);
            }

            return order;
        }

        public async Task<T> GetById<T>(int id)
        {
            var order = await this.orderRepository
                 .All()
                 .Where(o => o.Id == id)
                 .Include(o => o.Purchases).ThenInclude(x => x.AddedOptionalIngredients).ThenInclude(p => p.Ingridient)
                 .To<T>()
                 .FirstOrDefaultAsync();
            return order;
        }

        public async Task<int> GetCount()
        {
            int count = this.orderRepository.All().Count();

            return count;
        }

        public async Task UpdateAsync(Order order) 
        {
            this.orderRepository.Update(order);
            await this.orderRepository.SaveChangesAsync();
        }

        public void Update(Order order)
        {
            this.orderRepository.Update(order);
            this.orderRepository.SaveChangesAsync();
        }

        public void DeleteOrder(OrderDto orderDto)
        {
            var orderr = this.orderRepository.All().FirstOrDefault(x => x.Id == orderDto.Id);

            if (orderr == null)
            {
                throw new ArgumentNullException(nameof(orderr));
            }

            this.orderRepository.Delete(orderr);
            this.orderRepository.SaveChangesAsync();
        }

        public async Task<Order> GetOrderById(int Id)
        {
            var order = await this.orderRepository.All().Where(x => x.Id == Id)
                .Include(x => x.User).Include(x => x.Purchases).ThenInclude(x => x.Product).FirstOrDefaultAsync();

            return order;
        }
    }
}