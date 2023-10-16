using System.ComponentModel.DataAnnotations;

namespace Dashboard_Ecommerce.Dtos
{
    public class UserLoginDto
    {
        [Required,Display(Name ="User Name")]
        public string UserName { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
