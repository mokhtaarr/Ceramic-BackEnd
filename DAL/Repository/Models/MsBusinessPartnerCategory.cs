using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_BusinessPartnerCategory")]
    public partial class MsBusinessPartnerCategory
    {
        public MsBusinessPartnerCategory()
        {
            MsBusinessPartners = new HashSet<MsBusinessPartner>();
        }

        [Key]
        public int BsPartnerCatId { get; set; }
        [StringLength(50)]
        public string PartnerCatCode { get; set; } = null!;
        [StringLength(100)]
        public string? PartnerCatDescA { get; set; }
        [StringLength(100)]
        public string? PartnerCatDescE { get; set; }
        public int? ParentCustomerCatId { get; set; }
        public byte? CustomerCatType { get; set; }
        public int? CustomerCatLevel { get; set; }
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

        [InverseProperty("BsPartnerCat")]
        public virtual ICollection<MsBusinessPartner> MsBusinessPartners { get; set; }
    }
}
