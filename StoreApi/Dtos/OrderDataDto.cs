namespace StoreApi.Dtos
{
    public class OrderDataDto
    {
        public int SalesOfferId { get; set; }
        public decimal? NotPaid { get; set; }
        public DateTime? CreatedAt { get; set; }
        public List<OrderDetailDataDto> Details { get; set; }
    }

    public class OrderDetailDataDto
    {
        public int ItemCardId { get; set; }
        public string ItemDescA { get; set; }
        public string ItemDescE { get; set; }
        public int Quantity { get; set; }
        public decimal? Price { get; set; }
    }


}
