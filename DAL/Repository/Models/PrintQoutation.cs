using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Print_Qoutation")]
    public partial class PrintQoutation
    {
        public PrintQoutation()
        {
            PrintQoutationDetails = new HashSet<PrintQoutationDetail>();
        }

        [Key]
        public int PrinQoutId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? SalesOfferReqId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? EditPrinQoutId { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? CustomerId { get; set; }
        public int? EmpId { get; set; }
        public int? DepartMentId { get; set; }
        public int? CurrentEmpId { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CutterMetricLength { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? GofferMetricLength { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PurpuraMetricLength { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalLength { get; set; }
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

        [InverseProperty("PrinQout")]
        public virtual ICollection<PrintQoutationDetail> PrintQoutationDetails { get; set; }
    }
}
