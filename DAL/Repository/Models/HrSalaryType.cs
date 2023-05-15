using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_SalaryTypes")]
    public partial class HrSalaryType
    {
        public HrSalaryType()
        {
            HrEmpSalaryTypes = new HashSet<HrEmpSalaryType>();
            HrEmpsSalaryTemps = new HashSet<HrEmpsSalaryTemp>();
            HrSegments = new HashSet<HrSegment>();
        }

        [Key]
        public int SalaryTypId { get; set; }
        public int? AttendElementId { get; set; }
        public byte? SalaryCalcMethod { get; set; }
        [StringLength(50)]
        public string? SalaryCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SalaryValu { get; set; }
        public byte? UseType { get; set; }
        public byte? AffectType { get; set; }
        public byte? ImplementScale { get; set; }
        public int? ParentRelation { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Multiply { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Devide { get; set; }
        public byte? Approximation { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MaximumVal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MinimumVal { get; set; }
        public byte? DebitAccFilter { get; set; }
        public int? DebitAccId { get; set; }
        public byte? CreditAccFilter { get; set; }
        public int? CreditAccId { get; set; }
        public byte? DebitCostCenterFilter { get; set; }
        public int? DebitCostCenterId { get; set; }
        public byte? CreditCostCenterFilter { get; set; }
        public int? CreditCostCenterId { get; set; }
        public bool? LargerThanZero { get; set; }
        public bool? CanDelet { get; set; }
        public bool? AutoIssue { get; set; }
        public bool? CanEdit { get; set; }
        public bool? Distributable { get; set; }
        public bool? IsBasicsalary { get; set; }
        public byte? Indmnity { get; set; }
        public byte? Taxation { get; set; }
        public byte? SocialSecurity { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? ElementCount { get; set; }
        [StringLength(100)]
        public string? ElementCountDesc { get; set; }
        public bool? UseElementOrUnit { get; set; }
        public string? Equation { get; set; }
        public bool? IsAnnualSegment { get; set; }
        public int? AnnualPeriods { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Approx { get; set; }
        public bool? ApproxUp { get; set; }
        public bool? IsZeroIfLargerThan { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ZeroIfLargerThan { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AddField1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AddField2 { get; set; }
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

        [InverseProperty("SalaryTyp")]
        public virtual ICollection<HrEmpSalaryType> HrEmpSalaryTypes { get; set; }
        [InverseProperty("SalaryTyp")]
        public virtual ICollection<HrEmpsSalaryTemp> HrEmpsSalaryTemps { get; set; }
        [InverseProperty("SalaryTyp")]
        public virtual ICollection<HrSegment> HrSegments { get; set; }
    }
}
