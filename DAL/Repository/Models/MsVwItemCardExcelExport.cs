using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class MsVwItemCardExcelExport
    {
        [StringLength(50)]
        public string? PartCode { get; set; }
        [StringLength(100)]
        public string? PartDescA { get; set; }
        [StringLength(50)]
        public string? StoreCode { get; set; }
        [StringLength(100)]
        public string? StoreDescA { get; set; }
        [StringLength(50)]
        public string? ItemCode { get; set; }
        [StringLength(200)]
        public string? ItemDescA { get; set; }
        [StringLength(200)]
        public string? ItemDescE { get; set; }
        [StringLength(50)]
        public string? ItemCatCode { get; set; }
        [StringLength(100)]
        public string? ItemCatDescA { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity4 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price4 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price5 { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInBox { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? PurchasePrice { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyPartiation { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInNotebook { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverage { get; set; }
        public int ItemCardId { get; set; }
        public int? ItemCategoryId { get; set; }
        public byte? ItemType { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnittRate { get; set; }
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
        public byte? DefaultBarCode { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ManualPurchasePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastSalePrice { get; set; }
        public bool? IsDefaultSale { get; set; }
        public bool? IsDefaultPurchas { get; set; }
        [StringLength(50)]
        public string? UnitCode { get; set; }
        [StringLength(100)]
        public string? UnitNam { get; set; }
        [StringLength(10)]
        public string? Symbol { get; set; }
        public bool? IsExpir { get; set; }
        public int? ExpirPeriod { get; set; }
        public int? LotNumberExpiryId { get; set; }
        [StringLength(50)]
        public string? LotNumberExpiry { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ProdDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpiryDate { get; set; }
        public int? Period { get; set; }
        public bool? Disabled { get; set; }
        [Column("TVersion")]
        public long? Tversion { get; set; }
        [Column("TType")]
        [StringLength(1)]
        [Unicode(false)]
        public string? Ttype { get; set; }
        [Column("MaxTVersion")]
        public long? MaxTversion { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BeforLastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ReservedQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RequestedQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SaleNotDelivered { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PurNotReceived { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyOutWithoutBalance { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInWithoutCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SalesOrder { get; set; }
        public bool? IsCollection { get; set; }
        public bool? IsDimension { get; set; }
        public bool? IsAttributeItem { get; set; }
        public bool? IsSerialItem { get; set; }
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
        public int? StoreId { get; set; }
    }
}
