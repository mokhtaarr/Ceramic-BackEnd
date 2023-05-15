using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Print_Pricing")]
    public partial class PrintPricing
    {
        public PrintPricing()
        {
            PrintPricingDetails = new HashSet<PrintPricingDetail>();
        }

        [Key]
        public int PrinPriceId { get; set; }
        public int? PrinQoutId { get; set; }
        public int? PrinQoutDetailId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? EditPrinQoutId { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? CustomerId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? EmpId { get; set; }
        public int? CurrentEmpId { get; set; }
        public int? DepartMentId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SheetsQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProdWeight { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalWeight { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Parts { get; set; }
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
        public decimal? PaperPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Slofan { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ScrapPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Scrap { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProfitPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Profit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ItemPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ItemCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalSales { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalProfitPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalProfit { get; set; }
        [StringLength(200)]
        public string? AddField1 { get; set; }
        [StringLength(200)]
        public string? AddField2 { get; set; }
        [StringLength(200)]
        public string? AddField3 { get; set; }
        [StringLength(200)]
        public string? AddField4 { get; set; }
        [StringLength(200)]
        public string? AddField5 { get; set; }
        [StringLength(200)]
        public string? AddField6 { get; set; }
        [StringLength(200)]
        public string? AddField7 { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
        public bool? Closed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PermPrintedAt { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }

        [InverseProperty("PrinPrice")]
        public virtual ICollection<PrintPricingDetail> PrintPricingDetails { get; set; }
    }
}
