using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_ReturnSalesItemCard")]
    public partial class MsReturnSalesItemCard
    {
        public MsReturnSalesItemCard()
        {
            MsItemSerials = new HashSet<MsItemSerial>();
        }

        [Key]
        public int RetItemCardId { get; set; }
        public int? RetSaleId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? FollowCollectionId { get; set; }
        public int? ItemIdToFollow { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? InvItemCardId { get; set; }
        public int? TaxesId1 { get; set; }
        public byte? Tax1Style { get; set; }
        public bool? Tax1IsAccomulative { get; set; }
        public bool? Tax1PlusOrMinus { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Tax1Percent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxValue1 { get; set; }
        public int? TaxesId2 { get; set; }
        public byte? Tax2Style { get; set; }
        public bool? Tax2IsAccomulative { get; set; }
        public bool? Tax2PlusOrMinus { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Tax2Percent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxValue2 { get; set; }
        public int? TaxesId3 { get; set; }
        public byte? Tax3Style { get; set; }
        public bool? Tax3IsAccomulative { get; set; }
        public bool? Tax3PlusOrMinus { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Tax3Percent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxValue3 { get; set; }
        public int? JobOrderId { get; set; }
        [Column("jobProductId")]
        public int? JobProductId { get; set; }
        public int? ScaleCardId { get; set; }
        public int? UnitId { get; set; }
        public int? ItemOfferId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        [StringLength(60)]
        public string? BarCode { get; set; }
        [StringLength(20)]
        public string? BatchNumberFifoOrLifo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ReturnQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ReturnQtyBeforRate { get; set; }
        [Column("QtyIUnit2", TypeName = "numeric(38, 10)")]
        public decimal? QtyIunit2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QuantityOut { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyOutBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QuantityIn { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ServicePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProfitPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Kirat { get; set; }
        public bool? IsBonus { get; set; }
        public bool? IsCollection { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCostUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DisAmount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DisPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MainDiscPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MainDiscValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxableValue { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CommisionPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CommisionValue { get; set; }
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
        public bool? PriceIncludTaxInSales { get; set; }
        public bool? InOffer { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OfferPrice { get; set; }
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
        public byte[]? LastUpdateTime { get; set; }
        public int? MainServerId { get; set; }
        public int? ServerUnitId { get; set; }
        public int? ServerItemCardId { get; set; }

        [ForeignKey("ItemCardId")]
        [InverseProperty("MsReturnSalesItemCards")]
        public virtual MsItemCard? ItemCard { get; set; }
        [ForeignKey("RetSaleId")]
        [InverseProperty("MsReturnSalesItemCards")]
        public virtual MsReturnSale? RetSale { get; set; }
        [ForeignKey("UnitId")]
        [InverseProperty("MsReturnSalesItemCards")]
        public virtual MsItemUnit? Unit { get; set; }
        [InverseProperty("RetItemCard")]
        public virtual ICollection<MsItemSerial> MsItemSerials { get; set; }
    }
}
