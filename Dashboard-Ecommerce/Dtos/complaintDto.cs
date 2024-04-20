using System.ComponentModel.DataAnnotations;

namespace Dashboard_Ecommerce.Dtos
{
    public class complaintDto
    {
        public int ComId { get; set; }
        public string ComDesc { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required]
        public string Remarks { get; set; }

        [Required]
        public string Subject { get; set; }

         public IList<IFormFile> Image { get; set; }



    }
}
