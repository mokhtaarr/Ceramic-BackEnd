using System.ComponentModel.DataAnnotations;

namespace StoreApi.Dtos
{
    public class ResestPasswordDto
    {
        [Required]
        public string token { get;set; }
        [Required]
        public string Email { get;set; }
        [Required]
        public string NewPassword { get;set; }
    }
}
