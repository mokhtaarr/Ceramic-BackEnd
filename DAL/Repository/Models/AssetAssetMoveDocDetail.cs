using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Asset_AssetMoveDocDetail")]
    public partial class AssetAssetMoveDocDetail
    {
        [Key]
        public int AssetMovDetailId { get; set; }
        public int? AssetMovId { get; set; }
        public int? AssetId { get; set; }
        public int? OldStoreId { get; set; }
        public int? NewStoreId { get; set; }
        public int? OldDepartMentId { get; set; }
        public int? NewDepartMentId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MoveCost { get; set; }

        [ForeignKey("AssetMovId")]
        [InverseProperty("AssetAssetMoveDocDetails")]
        public virtual AssetAssetMoveDoc? AssetMov { get; set; }
    }
}
