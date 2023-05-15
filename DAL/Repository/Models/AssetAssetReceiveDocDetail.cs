using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Asset_AssetReceiveDocDetail")]
    public partial class AssetAssetReceiveDocDetail
    {
        [Key]
        public int ReceiveAssetDetailId { get; set; }
        public int? ReceiveAssetId { get; set; }
        public int? AssetId { get; set; }
        public int? EmpId { get; set; }
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

        [ForeignKey("ReceiveAssetId")]
        [InverseProperty("AssetAssetReceiveDocDetails")]
        public virtual AssetAssetReceiveDoc? ReceiveAsset { get; set; }
    }
}
