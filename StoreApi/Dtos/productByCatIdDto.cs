namespace StoreApi.Dtos
{
    public class productByCatIdDto
    {
        public int ItemCardId { get; set; }
        public string ItemDescA { get; set; }
        public string ItemDescE { get; set; }
        public decimal FirstPrice { get; set; }
        public string TaxItemCode { get; set; }

        public decimal Discount { get; set; }

        public decimal TotalCost { get; set; }

        public decimal QtyPartiation { get; set; }

    }
}
