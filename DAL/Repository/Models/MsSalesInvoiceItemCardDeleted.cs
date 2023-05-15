using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_SalesInvoiceItemCard_Deleted")]
    public partial class MsSalesInvoiceItemCardDeleted
    {
        [Key]
        public int DelInvItemcardId { get; set; }
        public int InvItemCardId { get; set; }
        public int? InvId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? AlterToItemCardId { get; set; }
        public int? CollectToItemCardId { get; set; }
        public int? AlterTo { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? TaxesId1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxValue1 { get; set; }
        public int? TaxesId2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxValue2 { get; set; }
        public int? TaxesId3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxValue3 { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        [StringLength(60)]
        public string? BarCode { get; set; }
        [StringLength(20)]
        public string? BatchNumberFifoOrLifo { get; set; }
        [StringLength(20)]
        public string? LotNumberExpiry { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ProductionDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpiryDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
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
        public decimal? DisAmount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DisPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DisAmountAfterRate { get; set; }
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
        [StringLength(100)]
        public string? ItemCardDesc { get; set; }
        [StringLength(100)]
        public string? ItemCardDescE { get; set; }
        public bool? IsBonus { get; set; }
        public bool? IsCollection { get; set; }
        public int? FollowCollectionId { get; set; }
        public int? ItemIdToFollow { get; set; }
        /// <summary>
        /// 1 Add, 0 Edit
        /// </summary>
        public bool? AddOrEditMode { get; set; }
        public int? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        /// <summary>
        /// 1Deleted,0 changed
        /// </summary>
        public bool? DeletedOrChanged { get; set; }
    }
}
