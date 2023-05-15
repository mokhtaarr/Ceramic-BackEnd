using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Quality_ItemDeliverDetails")]
    public partial class QualityItemDeliverDetail
    {
        [Key]
        public int ItemDeliverDetailId { get; set; }
        public int? ItemDeliverId { get; set; }
        public int? ItemRecQualityDetailId { get; set; }
        public int? ProdItemRecDetailId { get; set; }
        public int? ItemCardId { get; set; }
        public int? QualityCatId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        [StringLength(60)]
        public string? BarCode { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
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
        public decimal? MissedMachinQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MissedMachinQuantity { get; set; }
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
        [StringLength(100)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
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

        [ForeignKey("ItemDeliverId")]
        [InverseProperty("QualityItemDeliverDetails")]
        public virtual QualityItemDelivery? ItemDeliver { get; set; }
    }
}
