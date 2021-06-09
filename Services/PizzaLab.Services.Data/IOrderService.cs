using PizzaLab.Data.PizzaLab.Data.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Services.Data
{
    public interface IOrderService
    {
        Task<int> GetCount();
        Task<Order> CreateAsync(Order item);
        Task<T> GetById<T> (int id);
        Task<Order> GetBaseById(int id);
        Task UpdateAsync(Order order);
        Task<decimal?> GetTotalProfit();

        //Task<Order> ChangeStatus(int orderId, OrderStatusEnum statusEnum);

    }
}

