using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_Stores")]
    public partial class MsStore
    {
        public MsStore()
        {
            CalJurnalEntries = new HashSet<CalJurnalEntry>();
            MsPartitions = new HashSet<MsPartition>();
        }

        [Key]
        public int StoreId { get; set; }
        public int? UserId { get; set; }
        public int? UserGroupId { get; set; }
        [StringLength(50)]
        public string StoreCode { get; set; } = null!;
        [StringLength(100)]
        public string? StoreDescA { get; set; }
        [StringLength(100)]
        public string? StoreDescE { get; set; }
        /// <summary>
        /// true MainBranch , False Sub Branch
        /// </summary>
        public bool? StoreType { get; set; }
        [StringLength(100)]
        public string? StorePosition { get; set; }
        [StringLength(50)]
        public string? StoreKeeper { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(20)]
        public string? Fax { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(50)]
        public string? PrintHeaderFont { get; set; }
        [StringLength(50)]
        public string? PrintFooterFont { get; set; }
        [StringLength(50)]
        public string? PrintHeaderFontColor { get; set; }
        [StringLength(50)]
        public string? PrintFooterFontColor { get; set; }
        public byte? PrintHeaderFontSize { get; set; }
        public byte? PrintFooterFontSize { get; set; }
        public byte? PrintHeaderFontStyle { get; set; }
        public byte? PrintFooterFontStyle { get; set; }
        public int? BoxId { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        [Column(TypeName = "image")]
        public byte[]? BranchLogo { get; set; }
        [StringLength(500)]
        public string? PrintHeader { get; set; }
        [StringLength(500)]
        public string? PrintFooter { get; set; }
        [StringLength(50)]
        public string? EtaxCode { get; set; }
        [StringLength(50)]
        public string? TaxReg { get; set; }
        [StringLength(500)]
        public string? CommercialName { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey("BoxId")]
        [InverseProperty("MsStores")]
        public virtual MsBoxBank? Box { get; set; }
        [InverseProperty("Stor")]
        public virtual ICollection<CalJurnalEntry> CalJurnalEntries { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<MsPartition> MsPartitions { get; set; }
    }
}
