using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwItemCard
    {
        public int ItemCardId { get; set; }
        [StringLength(50)]
        public string? ItemCode { get; set; }
        [StringLength(100)]
        public string? ItemDescA { get; set; }
        [StringLength(100)]
        public string? ItemDescE { get; set; }
        [StringLength(13)]
        [Unicode(false)]
        public string? ItemType { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastSalePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BeforLastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCostManual { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ManualPurchasePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverage { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastPurchDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FirstPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SecandPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ThirdPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LargePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price5 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price6 { get; set; }
        public bool? InOffer { get; set; }
        public bool? IsExpir { get; set; }
        public bool? IsAttributeItem { get; set; }
        public bool? IsDimension { get; set; }
        public bool? IsCollection { get; set; }
        public bool? IsSerialItem { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ItemLimit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ItemMax { get; set; }
        [StringLength(50)]
        public string? ItemCatCode { get; set; }
        [StringLength(100)]
        public string? ItemCatDescA { get; set; }
        [StringLength(100)]
        public string? ItemCatDescE { get; set; }
        [StringLength(22)]
        [Unicode(false)]
        public string? ItemType2 { get; set; }
        public int? MainServerId { get; set; }
    }
}
