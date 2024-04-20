using DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace Dashboard_Ecommerce.Dtos
{
    public class ProductDto
    {
        public int ItemCardId { get; set; }
        [Required(ErrorMessage = "حقل الاسم مطلوب")]
        [StringLength(50, ErrorMessage = "يجب ألا يتجاوز طول الاسم 50 حرف")]
        [Display(Name = "Arabic Product Name")]
        public string ItemDescA { get; set; }
        [Required(ErrorMessage = "حقل الاسم مطلوب")]
        [StringLength(50, ErrorMessage = "يجب ألا يتجاوز طول الاسم 50 حرف")]
        [Display(Name = "English Product Name")]

        public string ItemDescE { get; set; }
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "يجب إدخال أرقام فقط في هذا الحقل")]

        public decimal TotalCost { get; set; }
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "يجب إدخال أرقام فقط في هذا الحقل")]

        public decimal Discount { get; set; }
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "يجب إدخال أرقام فقط في هذا الحقل")]

        public decimal QtyPartiation { get; set; }

        [Required(ErrorMessage = "حقل وصف المنتج مطلوب")]
        [Display(Name = "Arabic Product Description")]
        public string ProductDescA { get; set; }

        [Required(ErrorMessage = "حقل وصف المنتج مطلوب")]
        [Display(Name = "English Product Description")]
        public string ProductDescE { get; set; }

        public IFormFile UploadFile { get; set; }
        public IFormFile UploadFile2 { get; set; }
        public IFormFile UploadFile3 { get; set; }
        public IFormFile UploadFile4 { get; set; }
        public IFormFile UploadFile5 { get; set; }
        public IFormFile UploadFile6 { get; set; }
        public string ImgPath { get; set; }
        public string ImgPath2 { get; set; }
        public string ImgPath3 { get; set; }
        public string ImgPath4 { get; set; }
        public string ImgPath5 { get; set; }
        public string ImgPath6 { get; set; }
        public string TaxItemCode { get; set; }



        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        public IEnumerable<SrBrand> Brands { get; set; }

        [Display(Name = "Item Category")]
        public int ItemCategoryId { get; set; }
        public IEnumerable<MsItemCategory> Categories { get; set; }
    }
}
