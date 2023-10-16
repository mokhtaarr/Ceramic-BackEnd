namespace StoreApi.Dtos
{
    public class ProductDto
    {
        public int ItemCardId { get; set; }
        public string ItemDescA { get; set; }
        public string ItemDescE { get; set; }
        public decimal FirstPrice { get; set; }
        public string TaxItemCode { get; set; }
        public string ImgPath2 { get; set; }
        public string ImgPath3 { get; set; }
        public string ImgPath4 { get; set; }
        public string ImgPath5 { get; set; }
        public string ImgPath6 { get; set; }
        public decimal Discount { get; set; }

        public decimal TotalCost { get; set; }

        public decimal QtyPartiation { get; set; }



    }
}
