using System.ComponentModel.DataAnnotations;

namespace Dashboard_Ecommerce.Dtos
{
    public class UserDto
    {
        //[Required,MaxLength(200),MinLength(3),Display(Name = "First Name")]
        //public string FirstName { get; set; }
        //[Required, MaxLength(200), MinLength(3), Display(Name = "Last Name")]

        //public string LastName { get; set; }
        [Required, MaxLength(15), MinLength(3), Display(Name = "User Name")]

        public string UserName { get; set; }
        [Required,EmailAddress, Display(Name = "Email Address")]

        public string Email { get; set; }
        [Required, MaxLength(16), MinLength(6), Display(Name = "Password"),DataType(DataType.Password)]

        public string Password { get; set; }
        [Required,Compare("Password"), Display(Name = "Confirm password"), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}