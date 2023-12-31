using DAL.Models;

namespace Dashboard_Ecommerce.Dtos
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public int CustomerCatId { get; set; }
        public string CatDescA { get; set; }
        public IEnumerable<MsCustomerCategory> CustomerCategory { get; set; }
        public string CustomerCode { get; set; }

        public string CustomerDescA { get; set; }
        public string CustomerDescE { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Remarks { get; set; }
        public string Tel { get; set; }
        public string AddField1 { get; set; }
        public string AddField2 { get; set; }
        public string AddField3 { get; set; }

    }
}
