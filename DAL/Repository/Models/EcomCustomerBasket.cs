using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EcomCustomerBasket
    {

        public EcomCustomerBasket()
        {
                
        }

        public EcomCustomerBasket( string id)
        {
            CustomerBasketId= id;
        }
        public string CustomerBasketId { get; set; }
        public List<EcomBasketItem> Items { get; set; } = new List<EcomBasketItem>();
    }
}
