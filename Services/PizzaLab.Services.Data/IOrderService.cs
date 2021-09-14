using PizzaLab.Data.PizzaLab.Data.Models;
using PizzaLab.Web.ViewModels.DTO;
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

        Task<Order> GetOrderById(int id);

        Task UpdateAsync(Order order);
        void DeleteOrder(OrderDto orderDto);
    }
}