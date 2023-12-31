namespace Dashboard_Ecommerce.Dtos
{
    public class OrderDataDto
    {
        
            public int SalesOfferId { get; set; }
            public decimal? NotPaid { get; set; }

            public DateTime? CreatedAt { get; set; }
            //public int customerId { get; set; }
            public string CustomerDescA { get; set; }
            public string CustomerCode { get; set; }
        public List<OrderDetail> Details { get; set; }
      
    }

    public class OrderDetail
    {
        public int ItemCardId { get; set; }
        public string ItemDescA { get; set; }
        public int Quantity { get; set; }
        public decimal? Price { get; set; }
    }
}
