using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_WorkOrderProdItems")]
    public partial class ProdWorkOrderProdItem
    {
        [Key]
        public int WorkOrderProdItemId { get; set; }
        public int? WorkOrderId { get; set; }
        public int? ItemRecQualityDetailId { get; set; }
        public int? ItemRecQualityId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? ItemPatchPartitionId { get; set; }
        public int? ItemPartId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? BillOfMaterialId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        [StringLength(60)]
        public string? BarCode { get; set; }
        [StringLength(20)]
        public string? BatchNumberFifoOrLifo { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExecutedQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExecutedQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NormalCleanQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DoubleCleanQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MissedQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MissedQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NormalQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NormalQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DoublCheckQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DoublCheckQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RejectedQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RejectedQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceNormal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalNormal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceDoubleClean { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalDoubleClean { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ReturnQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ReturnQuantity { get; set; }
        [StringLength(100)]
        public string? ItemCardDesc { get; set; }
        [StringLength(100)]
        public string? ItemCardDescE { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RequestedMeter { get; set; }
        public bool? IsDelivered { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }

        [ForeignKey("WorkOrderId")]
        [InverseProperty("ProdWorkOrderProdItems")]
        public virtual ProdWorkOrder? WorkOrder { get; set; }
    }
}
