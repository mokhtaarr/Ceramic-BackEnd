using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Asset_DepreciationDocDetail")]
    public partial class AssetDepreciationDocDetail
    {
        [Key]
        public int DeprDocDetailId { get; set; }
        public int? DeprDocId { get; set; }
        public int? AssetId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value { get; set; }
        public int? DebitAccountId { get; set; }
        public int? CreditAccountId { get; set; }
        public int? DebitCostcenterId { get; set; }
        public int? CreditCostCenterId { get; set; }
        public int? DebitAssetAccountId { get; set; }
        public int? CreditAssetAccountId { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(100)]
        public string? Remarks3 { get; set; }

        [ForeignKey("DeprDocId")]
        [InverseProperty("AssetDepreciationDocDetails")]
        public virtual AssetDepreciationDoc? DeprDoc { get; set; }
    }
}
