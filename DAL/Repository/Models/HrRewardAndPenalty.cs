﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_RewardAndPenalty")]
    public partial class HrRewardAndPenalty
    {
        [Key]
        public int RewardId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? EmpId { get; set; }
        public int? EmpApprovedById { get; set; }
        public int? PeriodTableId { get; set; }
        public int? PeriodTablDetailId { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public bool? IsReward { get; set; }
        public bool? IsMoral { get; set; }
        public int? SalaryTypId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExecutDate { get; set; }
        [StringLength(100)]
        public string? UnitDesc { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitValue { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? IsDelivered { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
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
    }
}