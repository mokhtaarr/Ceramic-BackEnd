using System.ComponentModel.DataAnnotations;

namespace StoreApi.Dtos
{
    public class CategoryDto
    {
        public int ItemCategoryId { get; set; }

        public string ItemCatDescA { get; set; }

        public string ItemCatDescE { get; set; }
        public string ImagePath { get; set; }
        public string ImageDescription { get; set; }
        public string ImageDescriptionEn { get; set; }
    }
}
