using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwEmpAttendanceTran
    {
        public int TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public int? DepartMentId { get; set; }
        public int AttendDocDetailsId { get; set; }
        public int AttendDocId { get; set; }
        [StringLength(50)]
        public string? EmpCode { get; set; }
        [StringLength(50)]
        public string? DeviceEmpCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(50)]
        public string? DepartCode { get; set; }
        [StringLength(100)]
        public string? DepartName1 { get; set; }
        [StringLength(100)]
        public string? DepartName2 { get; set; }
        [Column("JCode")]
        [StringLength(50)]
        public string? Jcode { get; set; }
        [Column("JName1")]
        [StringLength(100)]
        public string? Jname1 { get; set; }
        [Column("JName2")]
        [StringLength(100)]
        public string? Jname2 { get; set; }
        [StringLength(50)]
        public string? PeriodCode { get; set; }
        [StringLength(100)]
        public string? PeriodName1 { get; set; }
        [StringLength(100)]
        public string? PeriodName2 { get; set; }
        [StringLength(50)]
        public string? SubPeriodCode { get; set; }
        [StringLength(100)]
        public string? SubPeriodName1 { get; set; }
        [StringLength(100)]
        public string? SubPeriodName2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PeriodStrtDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PeriodEndDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PayDayDate { get; set; }
        [StringLength(50)]
        public string? StoreCode { get; set; }
        [StringLength(100)]
        public string? StoreDescA { get; set; }
        [StringLength(100)]
        public string? StoreDescE { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalWorkHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalVacsHours { get; set; }
        public int? EmpId { get; set; }
        public int? PeriodTablDetailId { get; set; }
        public int? PeriodTableId { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
    }
}
