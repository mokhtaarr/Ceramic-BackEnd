using System.ComponentModel.DataAnnotations;

namespace StoreApi.Dtos
{
    public class AddressDto
    {
        [Required]
        public string FirstNameAr { get; set; }
        [Required]

        public string FirstNameEn { get; set; }
        [Required]

        public string LastNameAr { get; set; }
        [Required]

        public string LastNameEn { get; set; }
        [Required]

        public string Street { get; set; }
        [Required]

        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
