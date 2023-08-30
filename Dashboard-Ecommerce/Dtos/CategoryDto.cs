using System.ComponentModel.DataAnnotations;

namespace Dashboard_Ecommerce.Dtos
{
    public class CategoryDto
    {
        public int ItemCategoryId { get; set; }
        [Required,StringLength(50)]
        public string ItemCatDescA { get; set; }
        [Required, StringLength(50)]
        public string ItemCatDescE { get; set; }

        public IFormFile ImageFile { get; set; }

        public string ImagePath { get; set; }
        public string ImageDescription { get; set; }
        public string ImageDescriptionEn { get; set; }
        
    }
}
