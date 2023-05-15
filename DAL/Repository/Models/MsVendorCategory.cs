using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_VendorCategory")]
    public partial class MsVendorCategory
    {
        public MsVendorCategory()
        {
            MsVendors = new HashSet<MsVendor>();
        }

        [Key]
        public int VendorCatId { get; set; }
        [StringLength(50)]
        public string CatCode { get; set; } = null!;
        [StringLength(100)]
        public string? CatDescA { get; set; }
        [StringLength(100)]
        public string? CatDescE { get; set; }
        public int? ParentVendorCatId { get; set; }
        public int? VendorCatParent { get; set; }
        public int? VendorCatLevel { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [InverseProperty("VendorCat")]
        public virtual ICollection<MsVendor> MsVendors { get; set; }
    }
}
