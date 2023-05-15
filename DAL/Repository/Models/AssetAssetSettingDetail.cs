using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Asset_AssetSettingDetails")]
    public partial class AssetAssetSettingDetail
    {
        [Key]
        public int AssetSetDetails { get; set; }
        public int? AssetSetId { get; set; }
        public int? AssetId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeprStartDate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? UsablifeTime { get; set; }
        [Column(TypeName = "decimal(38, 10)")]
        public decimal? ScrapValu { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(100)]
        public string? Remarks3 { get; set; }
        [StringLength(100)]
        public string? Remarks4 { get; set; }

        [ForeignKey("AssetSetId")]
        [InverseProperty("AssetAssetSettingDetails")]
        public virtual AssetAssetSetting? AssetSet { get; set; }
    }
}
