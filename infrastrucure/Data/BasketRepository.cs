using DAL.interfaces;
using DAL.Models;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace infrastrucure.Data
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDatabase _database;
        public BasketRepository(IConnectionMultiplexer redis)
        {
            _database = redis.GetDatabase();
        }
        public async Task<bool> DeleteBasketAsync(string BasketId)
        {
            return await _database.KeyDeleteAsync(BasketId);
        }

        public async Task<EcomCustomerBasket> GetBasketAsync(string basketId)
        {
            var data = await _database.StringGetAsync(basketId);
            return data.IsNullOrEmpty ? null : JsonSerializer.Deserialize<EcomCustomerBasket>(data);
        }

        public async Task<EcomCustomerBasket> UpdateBasketAsync(EcomCustomerBasket basket)
        {
           var created = await _database.StringSetAsync(basket.CustomerBasketId,JsonSerializer.Serialize(basket),TimeSpan.FromDays(30));
            if (!created) return null;
            return await GetBasketAsync(basket.CustomerBasketId);

        }
    }
}
