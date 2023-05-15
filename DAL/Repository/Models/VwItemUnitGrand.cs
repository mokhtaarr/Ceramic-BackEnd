using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwItemUnitGrand
    {
        public int UnitId { get; set; }
        public int? ItemCardId { get; set; }
        public int? BasUnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ItemUnitRate { get; set; }
        [StringLength(60)]
        public string? BarCode1 { get; set; }
        [StringLength(60)]
        public string? BarCode2 { get; set; }
        [StringLength(60)]
        public string? BarCode3 { get; set; }
        [StringLength(60)]
        public string? BarCode4 { get; set; }
        [StringLength(60)]
        public string? BarCode5 { get; set; }
        public bool? IsDefaultSale { get; set; }
        public bool? IsDefaultPurchas { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price4 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity4 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price5 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity5 { get; set; }
        [StringLength(50)]
        public string? ItemCode { get; set; }
        [StringLength(100)]
        public string? ItemDescA { get; set; }
        [StringLength(100)]
        public string? ItemDescE { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverage { get; set; }
        [StringLength(50)]
        public string? UnitCode { get; set; }
        [StringLength(100)]
        public string? UnitNam { get; set; }
        [StringLength(100)]
        public string? UnitNameE { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BasicUnitRate { get; set; }
        [StringLength(10)]
        public string? Symbol { get; set; }
        public int? ParentUnit { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BeforLastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price6 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price7 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price8 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price9 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price10 { get; set; }
        [StringLength(60)]
        public string? BarCode6 { get; set; }
        [StringLength(60)]
        public string? BarCode7 { get; set; }
        [StringLength(60)]
        public string? BarCode8 { get; set; }
        [StringLength(60)]
        public string? BarCode9 { get; set; }
        [StringLength(60)]
        public string? BarCode10 { get; set; }
        [StringLength(60)]
        public string? BarCode11 { get; set; }
        [StringLength(60)]
        public string? BarCode12 { get; set; }
        [StringLength(60)]
        public string? BarCode13 { get; set; }
        [StringLength(60)]
        public string? BarCode14 { get; set; }
        [StringLength(60)]
        public string? BarCode15 { get; set; }
        public int? UnitMainServerId { get; set; }
        public int? ItemMainServerId { get; set; }
    }
}
