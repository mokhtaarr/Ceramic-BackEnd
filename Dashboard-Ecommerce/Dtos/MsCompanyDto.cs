using System.ComponentModel.DataAnnotations;

namespace Dashboard_Ecommerce.Dtos
{
    public class MsCompanyDto
    {
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "كلمه الشركه يالعربى مطلوبه")]
        [Display(Name = "company's word in Arabic")]
        public string RemarksA { get; set; }

        [Required(ErrorMessage = "كلمه الشركه بالإنجليزى مطلوبه")]
        [Display(Name = "company's word in English")]

        public string RemarksE { get; set; }
    }
}
