using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_UnitReplacement")]
    public partial class ProjUnitReplacement
    {
        [Key]
        public int UnitReplacId { get; set; }
        public int? ReservId { get; set; }
        public int? InstallTempDetailId { get; set; }
        public int? StoreId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? OldProjUnitId { get; set; }
        public int? ProjUnitId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? TrNo { get; set; }
        [StringLength(50)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalNotPaidInstallVal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DepositVal { get; set; }
        public int? DepositRectId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NewInstallVal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OldActualSalesPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ActualSalesPrice { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        public bool? Closed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NotPaid { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
        [StringLength(100)]
        public string? AddField3 { get; set; }
        [StringLength(100)]
        public string? AddField4 { get; set; }
        [StringLength(100)]
        public string? AddField5 { get; set; }
        [StringLength(100)]
        public string? AddField6 { get; set; }
        [StringLength(100)]
        public string? AddField7 { get; set; }
        [StringLength(100)]
        public string? AddField8 { get; set; }
        [StringLength(100)]
        public string? AddField9 { get; set; }
        [StringLength(100)]
        public string? AddField10 { get; set; }
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
    }
}
