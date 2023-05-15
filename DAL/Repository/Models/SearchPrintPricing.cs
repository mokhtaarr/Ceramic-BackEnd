using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchPrintPricing
    {
        public int? StoreId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(50)]
        public string CustomerCode { get; set; } = null!;
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        public int? PrinQoutId { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OuterBoxesCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PartsCount { get; set; }
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
        [StringLength(50)]
        public string? ItemCode { get; set; }
        [StringLength(200)]
        public string? ItemDescA { get; set; }
        [StringLength(200)]
        public string? ItemDescE { get; set; }
        [StringLength(250)]
        public string? ItemBatchCode { get; set; }
        [StringLength(500)]
        public string? ItemBatchName1 { get; set; }
        [StringLength(500)]
        public string? ItemBatchName2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PartsBySheet { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Zincs { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Forms { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Transportation { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Palets { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrepare { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Commision { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalSales { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalProfit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ItemPrice { get; set; }
        public int PrinPriceId { get; set; }
    }
}
