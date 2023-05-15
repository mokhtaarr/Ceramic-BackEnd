using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_SalesInvoiceItemCard")]
    [Index("InvId", Name = "Inv")]
    public partial class MsSalesInvoiceItemCard
    {
        public MsSalesInvoiceItemCard()
        {
            MsItemSerials = new HashSet<MsItemSerial>();
        }

        [Key]
        public int InvItemCardId { get; set; }
        public int? InvId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? DelivItemCardId { get; set; }
        public int? DeliverId { get; set; }
        [Column("CityIDFrom")]
        public int? CityIdfrom { get; set; }
        [Column("CityIDTo")]
        public int? CityIdto { get; set; }
        public int? AlterToItemCardId { get; set; }
        public int? CollectToItemCardId { get; set; }
        public int? FollowCollectionId { get; set; }
        public int? ItemIdToFollow { get; set; }
        public int? AlterTo { get; set; }
        public int? LotNumberExpiryId { get; set; }
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
        public int? PayId { get; set; }
        [Column("VJOrderId")]
        public int? VjorderId { get; set; }
        public int? PurInvId { get; set; }
        public int? PettycashId { get; set; }
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
        public decimal? QuantityOut { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyOutBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ReturnQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ReturnQtyBeforRate { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DisAmount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DisPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DisAmountAfterRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MainDiscPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MainDiscValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxableValue { get; set; }
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
        public bool? IsCommisionPercent { get; set; }
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
        public byte? PriceList { get; set; }
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
        public int? VehicleId1 { get; set; }
        public int? VehicleId2 { get; set; }
        [StringLength(100)]
        public string? DriverName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeEnd { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public int? MainServerId { get; set; }
        public int? ServerUnitId { get; set; }
        public int? ServerItemCardId { get; set; }

        [ForeignKey("InvId")]
        [InverseProperty("MsSalesInvoiceItemCards")]
        public virtual MsSalesInvoice? Inv { get; set; }
        [ForeignKey("ItemCardId")]
        [InverseProperty("MsSalesInvoiceItemCards")]
        public virtual MsItemCard? ItemCard { get; set; }
        [ForeignKey("UnitId")]
        [InverseProperty("MsSalesInvoiceItemCards")]
        public virtual MsItemUnit? Unit { get; set; }
        [InverseProperty("InvItemCard")]
        public virtual ICollection<MsItemSerial> MsItemSerials { get; set; }
    }
}
