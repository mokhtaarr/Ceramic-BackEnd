using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Print_QoutationDetails")]
    public partial class PrintQoutationDetail
    {
        public PrintQoutationDetail()
        {
            PrintQoutationDetailsItems = new HashSet<PrintQoutationDetailsItem>();
        }

        [Key]
        public int PrinQoutDetailId { get; set; }
        public int PrinQoutId { get; set; }
        public int? ItemCardId { get; set; }
        [StringLength(100)]
        public string? ItemCardDesc { get; set; }
        [StringLength(100)]
        public string? ItemCardDescE { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        public int? EditTypeId { get; set; }
        public byte? SizeSource { get; set; }
        public int? StockingId { get; set; }
        public int? DistributId { get; set; }
        public int? BoxTypeId { get; set; }
        public int? SectorId { get; set; }
        public int? GofferId { get; set; }
        public bool? IsDraw { get; set; }
        public bool? IsSample { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OuterBoxesCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PartsCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BoxCount { get; set; }
        public int? Layers { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OutOrderLength { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OutOrderWidth { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OutOrderHeight { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InOrderLength { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InOrderWidth { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InOrderHeight { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CutterLength { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CutterWidth { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CutterHeight { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CutterMetricLength { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? GofferMetricLength { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PurpuraMetricLength { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalLength { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        [StringLength(200)]
        public string? Remarks4 { get; set; }

        [ForeignKey("PrinQoutId")]
        [InverseProperty("PrintQoutationDetails")]
        public virtual PrintQoutation PrinQout { get; set; } = null!;
        [InverseProperty("PrinQoutDetail")]
        public virtual ICollection<PrintQoutationDetailsItem> PrintQoutationDetailsItems { get; set; }
    }
}
