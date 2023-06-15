using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EcomBasketItem
    {
        public int BasketItemId { get; set; }
        public string ProductName { get; set; }
        public string ProductNameEn { get; set; }
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }
        public string PictureUrl { get; set; }
       
    }
}
