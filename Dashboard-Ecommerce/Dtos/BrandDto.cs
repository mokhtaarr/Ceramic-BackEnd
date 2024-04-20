
using System.ComponentModel.DataAnnotations;

namespace Dashboard_Ecommerce.Dtos
{
    public class BrandDto
    {
        public int BrandId { get; set; }
        [Required, StringLength(20)]
        public string DescA { get; set; }

        [Required, StringLength(20)]
        public string DescE { get; set; }
        public IFormFile ImageFile { get; set; } 

        public string ImagePath { get; set; }
    }
}
