using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_JobOrderProducts")]
    public partial class ProdJobOrderProduct
    {
        [Key]
        [Column("jobProductId")]
        public int JobProductId { get; set; }
        public int? JobOrderId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? ItemPatchPartitionId { get; set; }
        public int? ItemPartId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? DescriptionId { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? BillOfMaterialId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public int? AnWeightRateId { get; set; }
        public int? AnWeightRateDetailId { get; set; }
        [StringLength(60)]
        public string? BarCode { get; set; }
        [StringLength(20)]
        public string? BatchNumberFifoOrLifo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBefore { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyAfter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QuantityOut { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyOutBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterRate { get; set; }
        public int? UnitIdEstimat { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRateEstimat { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QuantityEstimat { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRateEstimat { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceEstimat { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
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
        public decimal? BatchLength { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BatchWidth { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BatchHieght { get; set; }
        public bool? IsDelivered { get; set; }
        public bool? IsProduced { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ItemCostInPrcent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ItemCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpensesCostInPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpensesCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? JobsCostInPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? JobsCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MachineCostInPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MachineCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ScrapCostInPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ScrapCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Duration { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }

        [ForeignKey("ItemAtrribBatchId")]
        [InverseProperty("ProdJobOrderProducts")]
        public virtual ProdItemAttributesBatche? ItemAtrribBatch { get; set; }
        [ForeignKey("ItemCardId")]
        [InverseProperty("ProdJobOrderProducts")]
        public virtual MsItemCard? ItemCard { get; set; }
        [ForeignKey("JobOrderId")]
        [InverseProperty("ProdJobOrderProducts")]
        public virtual ProdJobOrder? JobOrder { get; set; }
    }
}
