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
       
        public OrderService(IRepository<Order> orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public async Task<Order> CreateAsync(Order order)
        {
            await this.orderRepository.AddAsync(order);
            await this.orderRepository.SaveChangesAsync();

            return order;
        }

        public async Task<T> GetById<T>(int id)
        {
            var order = await this.orderRepository
                 .All()
                 .Where(o => o.Id == id)
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
            var order = orderRepository.All().FirstOrDefault(x => x.Id == orderDto.Id);
            if (order == null)
            {
                throw new ArgumentNullException(nameof(orderDto));
            }

            orderRepository.Delete(order);
            orderRepository.SaveChangesAsync();
        }

        public async Task<Order> GetBaseById(int id)
        {
            var order = this.orderRepository.All().Where(x => x.Id == id)
                .Include(x => x.User).Include(x => x.Purchases).
                Include(x => x.DateTime).FirstOrDefault();

            return order;
        }
    }
}
