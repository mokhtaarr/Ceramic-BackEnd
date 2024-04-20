using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class MS_ItemCardView
    {
        [Key]
        public int ItemCardId { get; set; }
        public string ItemDescA { get; set; }
        public string ItemDescE { get; set; }
        public string ProductDescA { get; set; }
        public string ProductDescE { get; set; }
        public int BrandId { get; set; }
        public int ItemCategoryId { get; set; }
        public decimal TotalCost { get; set; }
        public decimal Discount { get; set; }
        public decimal FirstPrice { get; set; }
        public string TaxItemCode { get; set; }
        public string ImgPath2 { get; set; }
        public string ImgPath3 { get; set; }
        public string ImgPath4 { get; set; }
        public string ImgPath5 { get; set; }
        public string ImgPath6 { get; set; }
    }

}
