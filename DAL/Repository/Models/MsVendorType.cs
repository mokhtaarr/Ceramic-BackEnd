using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_VendorTypes")]
    public partial class MsVendorType
    {
        public MsVendorType()
        {
            MsVendors = new HashSet<MsVendor>();
        }

        [Key]
        public int VendorTypeId { get; set; }
        [StringLength(50)]
        public string VendorTypeCode { get; set; } = null!;
        [StringLength(100)]
        public string? VendorTypeDescA { get; set; }
        [StringLength(100)]
        public string? VendorTypeDescE { get; set; }
        public int? VendorTypeParent { get; set; }
        public int? VendorTypeLevel { get; set; }
        public byte? VendorTypeLevelType { get; set; }
        public int? CurrentTrNo { get; set; }
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

        [InverseProperty("VendorType")]
        public virtual ICollection<MsVendor> MsVendors { get; set; }
    }
}
