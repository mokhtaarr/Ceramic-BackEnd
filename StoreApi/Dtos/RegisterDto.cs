using System.ComponentModel.DataAnnotations;

namespace StoreApi.Dtos
{
    public class RegisterDto
    {
        [Required]

        public string DisplayName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]

        public string Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]

        public string City { get; set; }
        [Required]

        public string Street { get; set; }
    }
}
