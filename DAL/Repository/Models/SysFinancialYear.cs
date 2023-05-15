using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sys_FinancialYears")]
    public partial class SysFinancialYear
    {
        public SysFinancialYear()
        {
            SysFinancialIntervals = new HashSet<SysFinancialInterval>();
        }

        [Key]
        public int FinancialYearsId { get; set; }
        public int? FinancialYearsCode { get; set; }
        [StringLength(100)]
        public string? FinancialYearNameA { get; set; }
        [StringLength(100)]
        public string? FinancialYearNameE { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartingFrom { get; set; }
        [StringLength(20)]
        public string? StartingFromHijri { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndTo { get; set; }
        [StringLength(20)]
        public string? EndToHijri { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ClosingDate { get; set; }
        [StringLength(20)]
        public string? ClosingDateHijri { get; set; }
        [StringLength(500)]
        public string? YearState { get; set; }
        public int? NoOfIntervals { get; set; }
        public bool? YearType { get; set; }
        public byte? SubPeriodsType { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsActive { get; set; }
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

        [InverseProperty("FinancialYear")]
        public virtual ICollection<SysFinancialInterval> SysFinancialIntervals { get; set; }
    }
}
