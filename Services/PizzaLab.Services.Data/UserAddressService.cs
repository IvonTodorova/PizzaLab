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
    public class UserAddressService: IUserAddressService
    {
        private readonly IRepository<UserAddress> userAddressRepository;
        public UserAddressService(IRepository<UserAddress> userAddressRepository)
        {
            this.userAddressRepository = userAddressRepository;
        }

        public async Task<UserAddress> CreateAsync(UserAddress user)
        {
            await this.userAddressRepository.AddAsync(user);
            await this.userAddressRepository.SaveChangesAsync();

            return user;
        }

        public async Task<UserAddress> GetUserAddressByApplicationUser(string applicationUserId)
        {
            var userAddress = await this.userAddressRepository.All().FirstOrDefaultAsync(x => x.ApplicationUser.Id == applicationUserId);

            return userAddress;
        }

        public async Task<T> GetByUserId<T> (int userId)
        {
            var query = this.userAddressRepository.All().Where(x => x.UserAddressId == userId);

            var user = await query.To<T>().FirstOrDefaultAsync();

            return user;
        }


        public async Task<UserAddress> UpdateAsync(UserAddress userAddress)
        {
            this.userAddressRepository.Update(userAddress);
            await this.userAddressRepository.SaveChangesAsync();

            return userAddress;
        }
    }
}
