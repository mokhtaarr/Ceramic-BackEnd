using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Asset_AssetCategory")]
    public partial class AssetAssetCategory
    {
        public AssetAssetCategory()
        {
            AssetAssetCards = new HashSet<AssetAssetCard>();
            InverseParentAssetCat = new HashSet<AssetAssetCategory>();
        }

        [Key]
        public int AssetCatId { get; set; }
        [StringLength(50)]
        public string? CatCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public int? ParentAssetCatId { get; set; }
        public byte? AssetCatType { get; set; }
        public int? AssetCatLevel { get; set; }
        [StringLength(250)]
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

        [ForeignKey("ParentAssetCatId")]
        [InverseProperty("InverseParentAssetCat")]
        public virtual AssetAssetCategory? ParentAssetCat { get; set; }
        [InverseProperty("AssetCat")]
        public virtual ICollection<AssetAssetCard> AssetAssetCards { get; set; }
        [InverseProperty("ParentAssetCat")]
        public virtual ICollection<AssetAssetCategory> InverseParentAssetCat { get; set; }
    }
}
