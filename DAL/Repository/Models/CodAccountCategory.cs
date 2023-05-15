using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cod_AccountCategories")]
    public partial class CodAccountCategory
    {
        public CodAccountCategory()
        {
            CodAccountClassifications = new HashSet<CodAccountClassification>();
        }

        [Key]
        public int AccountCatId { get; set; }
        public int? ParentAccountCatId { get; set; }
        public long? Code { get; set; }
        [StringLength(100)]
        public string? DescA { get; set; }
        [StringLength(100)]
        public string? DescE { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public byte? AccountCatType { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        [StringLength(255)]
        public string? RemarksA { get; set; }
        [StringLength(255)]
        public string? RemarksE { get; set; }

        [ForeignKey("Aid")]
        [InverseProperty("CodAccountCategories")]
        public virtual SysAnalyticalCode? AidNavigation { get; set; }
        [InverseProperty("AccountCat")]
        public virtual ICollection<CodAccountClassification> CodAccountClassifications { get; set; }
    }
}
