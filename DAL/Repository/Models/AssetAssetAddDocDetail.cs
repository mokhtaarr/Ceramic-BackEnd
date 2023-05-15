using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Asset_AssetAddDocDetail")]
    public partial class AssetAssetAddDocDetail
    {
        [Key]
        public int AddAssetDetailId { get; set; }
        public int? AssetAddId { get; set; }
        public int? AssetId { get; set; }
        public int? AssetAccountId { get; set; }
        public int? CostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AddValue { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(100)]
        public string? Remarks3 { get; set; }

        [ForeignKey("AssetAddId")]
        [InverseProperty("AssetAssetAddDocDetails")]
        public virtual AssetAssetAddDoc? AssetAdd { get; set; }
    }
}
