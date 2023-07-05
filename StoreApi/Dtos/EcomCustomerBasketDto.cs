using DAL.Models;

namespace StoreApi.Dtos
{
    public class EcomCustomerBasketDto
    {
        public string CustomerBasketId { get; set; }
        public List<EcomBasketItemDto> Items { get; set; }
    }
}
