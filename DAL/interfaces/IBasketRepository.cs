using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IBasketRepository
    {
        Task<EcomCustomerBasket> GetBasketAsync(string basketId);
        Task<EcomCustomerBasket> UpdateBasketAsync(EcomCustomerBasket basket);
        Task<bool> DeleteBasketAsync(string BasketId);
    }
}
