using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_SalesOfferItemRequest")]
    public partial class MsSalesOfferItemRequest
    {
        [Key]
        public int SalesOffertemCardReqId { get; set; }
        public int? SalesOfferReqId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
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
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        [StringLength(100)]
        public string? ItemCardDesc { get; set; }
        [StringLength(100)]
        public string? ItemCardDescE { get; set; }
        [StringLength(60)]
        public string? BarCode { get; set; }
        [StringLength(20)]
        public string? BatchNumberFifoOrLifo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExecuteQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExecuteQtyBeforRate { get; set; }
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
        public bool? IsCollection { get; set; }
        public bool? IsBonus { get; set; }
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
        [StringLength(100)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(100)]
        public string? Remarks3 { get; set; }
        public bool? PriceIncludTaxInSales { get; set; }

        [ForeignKey("SalesOfferReqId")]
        [InverseProperty("MsSalesOfferItemRequests")]
        public virtual MsSalesOfferRequest? SalesOfferReq { get; set; }
    }
}
