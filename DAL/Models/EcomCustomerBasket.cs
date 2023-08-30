using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Key]
        public string CustomerBasketId { get; set; }
        public List<EcomBasketItem> Items { get; set; } = new List<EcomBasketItem>();
    }
}
