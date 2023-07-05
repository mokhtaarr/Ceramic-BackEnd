using System.ComponentModel.DataAnnotations;

namespace StoreApi.Dtos
{
    public class EcomBasketItemDto
    {
        [Required]
        public int BasketItemId { get; set; }
        [Required]

        public string ProductName { get; set; }

        public string ProductNameEn { get; set; }
        [Required]
       
        public decimal? Price { get; set; }
        [Required]

        public decimal? Quantity { get; set; }
        [Required]

        public string PictureUrl { get; set; }
    }
}
