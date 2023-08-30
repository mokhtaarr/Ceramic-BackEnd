using System.ComponentModel.DataAnnotations;

namespace StoreApi.Dtos
{
    public class ConfirmEmailDto
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public string UserId { get; set; }
    }
}
