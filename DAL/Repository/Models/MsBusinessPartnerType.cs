using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_BusinessPartnerType")]
    public partial class MsBusinessPartnerType
    {
        public MsBusinessPartnerType()
        {
            MsBusinessPartners = new HashSet<MsBusinessPartner>();
        }

        [Key]
        public int BsPartnerTypeId { get; set; }
        [StringLength(50)]
        public string PartnerTypeCode { get; set; } = null!;
        [StringLength(100)]
        public string? PartnerTypeDescA { get; set; }
        [StringLength(100)]
        public string? PartnerTypeDescE { get; set; }
        public int? PartnerTypeParent { get; set; }
        public int? PartnerTypeLevel { get; set; }
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

        [InverseProperty("BsPartnerType")]
        public virtual ICollection<MsBusinessPartner> MsBusinessPartners { get; set; }
    }
}
