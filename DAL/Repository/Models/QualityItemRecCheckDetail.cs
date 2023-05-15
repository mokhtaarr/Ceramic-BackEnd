using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Quality_ItemRecCheckDetail")]
    public partial class QualityItemRecCheckDetail
    {
        [Key]
        public int ItemRecQualityDetailId { get; set; }
        public int? ItemRecQualityId { get; set; }
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
        public decimal? MissedQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MissedQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceNormal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalNormal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceDoubleClean { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalDoubleClean { get; set; }
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

        [ForeignKey("ItemRecQualityId")]
        [InverseProperty("QualityItemRecCheckDetails")]
        public virtual QualityItemRecCheck? ItemRecQuality { get; set; }
    }
}
