using System.ComponentModel.DataAnnotations;

namespace StoreApi.Dtos
{
    public class AddCustomerDto
    {

        [Required, MaxLength(50)]
        public string CustomerCode { get; set; }
        [Required, MaxLength(100)]
        public string CustomerDescA { get; set; }
        [Required, MaxLength(100)]
        public string CustomerDescE { get; set; }

        public string Tel { get; set; }

        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string AddField1 { get; set; }
        public string AddField2 { get; set; }
        public string AddField3 { get; set; }
        public string Remarks { get; set; }

    }
}
