using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchEmpActivity
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public int TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(50)]
        public string? SubPeriodCode { get; set; }
        [StringLength(100)]
        public string? PeriodName1 { get; set; }
        [StringLength(100)]
        public string? PeriodName2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalWorkDays { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalWorkHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalVacsDays { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalVacsHours { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
    }
}
