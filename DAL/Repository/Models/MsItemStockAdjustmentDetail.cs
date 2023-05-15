using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ItemStockAdjustmentDetail")]
    public partial class MsItemStockAdjustmentDetail
    {
        public MsItemStockAdjustmentDetail()
        {
            MsItemSerials = new HashSet<MsItemSerial>();
        }

        [Key]
        public int StockAdjustItemId { get; set; }
        public int? StockAdjustId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        [StringLength(60)]
        public string? BarCode { get; set; }
        [StringLength(20)]
        public string? BatchNumberFifoOrLifo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NewQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRateNew { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OldQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRateOld { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiffQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiffQtyBeforRate { get; set; }
        [Column("QtyIUnit2", TypeName = "numeric(38, 10)")]
        public decimal? QtyIunit2 { get; set; }
        [Column("FIFOCost", TypeName = "numeric(38, 10)")]
        public decimal? Fifocost { get; set; }
        [Column("FIFOCostUnit", TypeName = "numeric(38, 10)")]
        public decimal? FifocostUnit { get; set; }
        [Column("LIFOCost", TypeName = "numeric(38, 10)")]
        public decimal? Lifocost { get; set; }
        [Column("LIFOCostUnit", TypeName = "numeric(38, 10)")]
        public decimal? LifocostUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverage { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverageUnit { get; set; }
        [Column("FIFOCostOld", TypeName = "numeric(38, 10)")]
        public decimal? FifocostOld { get; set; }
        [Column("FIFOCostOldUnit", TypeName = "numeric(38, 10)")]
        public decimal? FifocostOldUnit { get; set; }
        [Column("LIFOCostOld", TypeName = "numeric(38, 10)")]
        public decimal? LifocostOld { get; set; }
        [Column("LIFOCostOldUnit", TypeName = "numeric(38, 10)")]
        public decimal? LifocostOldUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverageOld { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverageOldUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCostUnit { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(100)]
        public string? Remarks3 { get; set; }
        [StringLength(100)]
        public string? ItemCardDesc { get; set; }
        [StringLength(100)]
        public string? ItemCardDescE { get; set; }

        [ForeignKey("ItemCardId")]
        [InverseProperty("MsItemStockAdjustmentDetails")]
        public virtual MsItemCard? ItemCard { get; set; }
        [ForeignKey("StockAdjustId")]
        [InverseProperty("MsItemStockAdjustmentDetails")]
        public virtual MsItemStockAdjustment? StockAdjust { get; set; }
        [InverseProperty("StockAdjustItem")]
        public virtual ICollection<MsItemSerial> MsItemSerials { get; set; }
    }
}
