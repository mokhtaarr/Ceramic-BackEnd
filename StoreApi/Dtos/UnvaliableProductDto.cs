namespace StoreApi.Dtos
{
    public class UnvaliableProductDto
    {
     
        public string ProductNameAr { get; set; }
        public string ProductDescA { get; set; }
        public decimal Price { get; set; }
        public string Phone { get; set; }
        public IFormFile Image { get; set; }
    }
}
