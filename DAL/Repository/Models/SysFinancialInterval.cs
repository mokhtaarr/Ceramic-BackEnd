using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sys_FinancialIntervals")]
    public partial class SysFinancialInterval
    {
        [Key]
        public int FinancialIntervalsId { get; set; }
        [StringLength(20)]
        public string? FinancialIntervalCode { get; set; }
        [StringLength(50)]
        public string? MonthNameA { get; set; }
        [StringLength(50)]
        public string? MonthNameE { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartingFrom { get; set; }
        [StringLength(20)]
        public string? StartingFromHijri { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndingDate { get; set; }
        [StringLength(20)]
        public string? EndToHijri { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsInUse { get; set; }
        [StringLength(500)]
        public string? StopReason { get; set; }
        public int? StoppedByUserId { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        public int? FinancialYearId { get; set; }

        [ForeignKey("FinancialYearId")]
        [InverseProperty("SysFinancialIntervals")]
        public virtual SysFinancialYear? FinancialYear { get; set; }
    }
}
