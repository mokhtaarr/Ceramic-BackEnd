using System.ComponentModel.DataAnnotations;

namespace Dashboard_Ecommerce.Dtos
{
    public class CreateUserDto
    {
       
        [Required, MaxLength(15), MinLength(3), Display(Name = "User Name")]
        public string userName { get; set; }


        [Required, MaxLength(15), MinLength(3)]
        public string City { get; set; }


        [Required, MaxLength(15), MinLength(3)]
        public string Street { get; set; }


        [Required, MaxLength(11), MinLength(11)]
        public string PhoneNumber { get; set; }

        [Required, EmailAddress, Display(Name = "Email Address")]

        public string Email { get; set; }
        [Required, MaxLength(16), MinLength(4), Display(Name = "Password"), DataType(DataType.Password)]

        public string Password { get; set; }
        [Required, Compare("Password"), Display(Name = "Confirm password"), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
