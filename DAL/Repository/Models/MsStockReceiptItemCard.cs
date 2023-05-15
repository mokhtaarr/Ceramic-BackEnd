using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_StockReceiptItemCard")]
    public partial class MsStockReceiptItemCard
    {
        public MsStockReceiptItemCard()
        {
            MsItemSerials = new HashSet<MsItemSerial>();
        }

        [Key]
        public int StockRecItemCardId { get; set; }
        public int? StockRecId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? InvItemCardId { get; set; }
        public int? RetPurchItemCardId { get; set; }
        [Column("jobGoStockId")]
        public int? JobGoStockId { get; set; }
        [Column("jobProductId")]
        public int? JobProductId { get; set; }
        [Column("jobScrapId")]
        public int? JobScrapId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? FollowCollectionId { get; set; }
        public int? ItemIdToFollow { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? ScaleCardId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public int? BillOfMaterialId { get; set; }
        public byte? ItemType { get; set; }
        [StringLength(60)]
        public string? BarCode { get; set; }
        [StringLength(20)]
        public string? BatchNumberFifoOrLifo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        [Column("QtyIUnit2", TypeName = "numeric(38, 10)")]
        public decimal? QtyIunit2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QuantityIn { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterRate { get; set; }
        public int? VehicleId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ServicePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProfitPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Kirat { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforDiscount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyDiscount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QualityDiscount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QualityValueDisc { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyScalDiffrence { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyScalDiffrenceValue { get; set; }
        public bool? IsBonus { get; set; }
        public bool FireTriger { get; set; }
        public bool? IsCollection { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenseShare { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenseShareUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterExpense { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterExpenseUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterCurrUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenseShareAfterCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenseShareAfterCurrUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterExpenseAfterCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterExpensAfterCurrUnit { get; set; }
        public byte? Satus { get; set; }
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
        public int? IsNoCostDeliver { get; set; }
        public bool? DeliverNoCostExecut { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [Column("DBTableName")]
        [StringLength(100)]
        public string? DbtableName { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [Column("DBTableId")]
        public int? DbtableId { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [StringLength(100)]
        public string? AccountTableName { get; set; }
        public byte? RectSourceType { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? AccountId { get; set; }
        public int? RectSourceTypeId { get; set; }
        public int? AnimalAge { get; set; }
        [Column("ISMedicinNotify")]
        public bool? IsmedicinNotify { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public int? MainServerId { get; set; }
        public int? ServerUnitId { get; set; }
        public int? ServerItemCardId { get; set; }

        [ForeignKey("ItemCardId")]
        [InverseProperty("MsStockReceiptItemCards")]
        public virtual MsItemCard? ItemCard { get; set; }
        [ForeignKey("StockRecId")]
        [InverseProperty("MsStockReceiptItemCards")]
        public virtual MsStockRecript? StockRec { get; set; }
        [ForeignKey("UnitId")]
        [InverseProperty("MsStockReceiptItemCards")]
        public virtual MsItemUnit? Unit { get; set; }
        [InverseProperty("StockRecItemCard")]
        public virtual ICollection<MsItemSerial> MsItemSerials { get; set; }
    }
}
