using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_PeriodTableDetail")]
    public partial class HrPeriodTableDetail
    {
        [Key]
        public int PeriodTablDetailId { get; set; }
        public int? PeriodTableId { get; set; }
        [StringLength(50)]
        public string? SubPeriodCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PeriodStrtDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PeriodEndDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PayDayDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalWorkDays { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalWorkHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalVacsDays { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalVacsHours { get; set; }
        public byte? TotalDays { get; set; }

        [ForeignKey("PeriodTableId")]
        [InverseProperty("HrPeriodTableDetails")]
        public virtual HrPeriodsTable? PeriodTable { get; set; }
    }
}
