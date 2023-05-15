using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_Jobs")]
    public partial class HrJob
    {
        public HrJob()
        {
            HrEmployees = new HashSet<HrEmployee>();
        }

        [Key]
        public int JobId { get; set; }
        public int? DepartMentId { get; set; }
        [Column("JCode")]
        [StringLength(50)]
        public string? Jcode { get; set; }
        [Column("JName1")]
        [StringLength(100)]
        public string? Jname1 { get; set; }
        [Column("JName2")]
        [StringLength(100)]
        public string? Jname2 { get; set; }
        [Column("JDesc")]
        [StringLength(500)]
        public string? Jdesc { get; set; }
        [Column("JResponsibilities")]
        [StringLength(500)]
        public string? Jresponsibilities { get; set; }
        [Column("JDuties")]
        [StringLength(500)]
        public string? Jduties { get; set; }
        [Column("JQualifications")]
        [StringLength(500)]
        public string? Jqualifications { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        [StringLength(50)]
        public string? Add1 { get; set; }
        public int? ParentId { get; set; }
        public bool? TestMandatory { get; set; }
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
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? StandardMonthlyWage { get; set; }
        public byte? StandardHolyDays { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? StandardDailyWage { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? StandardDailyWorkHours { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? StandardHourlyWage { get; set; }
        public int? NumberAvailable { get; set; }

        [InverseProperty("Job")]
        public virtual ICollection<HrEmployee> HrEmployees { get; set; }
    }
}
