using System.ComponentModel.DataAnnotations;

namespace Dashboard_Ecommerce.Dtos
{
    public class CategoryDto
    {
        public int ItemCategoryId { get; set; }
        [Required,StringLength(100)]
        public string ItemCatDescA { get; set; }
        [Required, StringLength(100)]
        public string ItemCatDescE { get; set; }
    }
}
