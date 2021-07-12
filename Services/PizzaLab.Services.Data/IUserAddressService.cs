using PizzaLab.Data.PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Services.Data
{
    public interface IUserAddressService
    {
        Task<T> GetByUserId<T>(int userId);

        Task<UserAddress> GetUserAddressByApplicationUser(string applicationUserId);

        Task<UserAddress> CreateAsync(UserAddress address);

        Task<UserAddress> UpdateAsync(UserAddress address);
    }
}
