using DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace Dashboard_Ecommerce.Dtos
{
    public class ProductDto
    {
        public int ItemCardId { get;set; }
        [Required, StringLength(300)]
        [Display(Name = "Arabic Product Name")]
        public string ItemDescA { get; set; }
        [Required, StringLength(300)]
        [Display(Name = "English Product Name")]

        public string ItemDescE { get; set; }
        [Required]
        public decimal TotalCost { get; set; }

        public decimal Discount { get;set; }

        [Required]
        public decimal QtyPartiation { get; set; }
        
        public string TaxItemCode { get;set; }
        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        public IEnumerable<SrBrand> Brands { get; set; }

        [Display(Name ="Item Category")]
        public int ItemCategoryId { get;set; }
        public IEnumerable<MsItemCategory> Categories { get; set; }
    }
}
