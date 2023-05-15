using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_Employees")]
    public partial class HrEmployee
    {
        public HrEmployee()
        {
            CalEmpAccounts = new HashSet<CalEmpAccount>();
            HrEmpSalaryTypes = new HashSet<HrEmpSalaryType>();
            MsCheqBooks = new HashSet<MsCheqBook>();
            ProjProjectItemEmpJoins = new HashSet<ProjProjectItemEmpJoin>();
            SrEmpServicTypes = new HashSet<SrEmpServicType>();
            SrTaskEmps = new HashSet<SrTaskEmp>();
        }

        [Key]
        public int EmpId { get; set; }
        public int? StoreId { get; set; }
        public int? JobId { get; set; }
        public int? DepartMentId { get; set; }
        [Column("HREmpGroupId")]
        public int? HrempGroupId { get; set; }
        public int? PeriodTableId { get; set; }
        public int? ShiftId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        [StringLength(50)]
        public string? EmpCode { get; set; }
        [StringLength(50)]
        public string? DeviceEmpCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(500)]
        public string? Qualification { get; set; }
        public bool? Gender { get; set; }
        /// <summary>
        /// 0 single,1 married,2 married and have kids
        /// </summary>
        public byte? MaritalStatus { get; set; }
        public byte? KidsNo { get; set; }
        public byte? Religion { get; set; }
        public byte? Nationality { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        [Column("IDNo")]
        [StringLength(50)]
        public string? Idno { get; set; }
        [Column("IDIssueDate", TypeName = "smalldatetime")]
        public DateTime? IdissueDate { get; set; }
        [Column("IDExpiryDate", TypeName = "smalldatetime")]
        public DateTime? IdexpiryDate { get; set; }
        [StringLength(50)]
        public string? PassportNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PassportIssueDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PassportExpiryDate { get; set; }
        [StringLength(50)]
        public string? Car { get; set; }
        [StringLength(50)]
        public string? DrivingLicense { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DrivingIssueDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DrivingExpiryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DrivingRenewalDate { get; set; }
        [StringLength(20)]
        public string? Phone1 { get; set; }
        [StringLength(20)]
        public string? Phone2 { get; set; }
        [StringLength(20)]
        public string? Phone3 { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(200)]
        public string? Address1 { get; set; }
        [StringLength(200)]
        public string? Address2 { get; set; }
        public byte? AnnualVacs { get; set; }
        public byte? ReservedVacs { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastVacsUpdate { get; set; }
        public byte? AnnualVacsBalance { get; set; }
        public byte? ReservedVacsBalance { get; set; }
        public byte? MaxVacsBalance { get; set; }
        /// <summary>
        /// true limited, false unlimited
        /// </summary>
        public bool? ContractType { get; set; }
        /// <summary>
        /// true full Time,false Part time
        /// </summary>
        public bool? Attendance { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ContractSrtDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ContractEndDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? WorkStartDate { get; set; }
        [Column("SocialSecurityID")]
        [StringLength(30)]
        public string? SocialSecurityId { get; set; }
        [Column("HealthInsID")]
        [StringLength(30)]
        public string? HealthInsId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? HealthInsEndDate { get; set; }
        [Column("syndicate")]
        [StringLength(30)]
        public string? Syndicate { get; set; }
        [Column("syndicateID")]
        [StringLength(30)]
        public string? SyndicateId { get; set; }
        public byte? MilitaryService { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? HourlyCostRate { get; set; }
        public bool? IsTechnician { get; set; }
        public bool? IsSales { get; set; }
        public bool? IsMoneyCollector { get; set; }
        [StringLength(100)]
        public string? TaxRefNo { get; set; }
        /// <summary>
        /// Business  tax Reg Required,Person   NationalID not required,Foreigner  Name and ID  required
        /// </summary>
        [StringLength(50)]
        public string? EtaxCustType { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal? Evaluation { get; set; }
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
        [Column(TypeName = "image")]
        public byte[]? EmpImage { get; set; }
        public bool? IssueSalary { get; set; }
        public bool? DistributeSalary { get; set; }
        public bool? AutosalaryIssue { get; set; }
        [StringLength(80)]
        public string? BankName { get; set; }
        [StringLength(50)]
        public string? BankAccNo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DailyCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? HourlyCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalDailyCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalHourlyCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CommisionPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CommisionCollectionPerc { get; set; }
        public bool? IsCommissionAfterDisc { get; set; }

        [ForeignKey("DepartMentId")]
        [InverseProperty("HrEmployees")]
        public virtual HrDepartment? DepartMent { get; set; }
        [ForeignKey("HrempGroupId")]
        [InverseProperty("HrEmployees")]
        public virtual HrEmpGroup? HrempGroup { get; set; }
        [ForeignKey("JobId")]
        [InverseProperty("HrEmployees")]
        public virtual HrJob? Job { get; set; }
        [ForeignKey("PeriodTableId")]
        [InverseProperty("HrEmployees")]
        public virtual HrPeriodsTable? PeriodTable { get; set; }
        [ForeignKey("ShiftId")]
        [InverseProperty("HrEmployees")]
        public virtual HrShift? Shift { get; set; }
        [InverseProperty("Emp")]
        public virtual ICollection<CalEmpAccount> CalEmpAccounts { get; set; }
        [InverseProperty("Emp")]
        public virtual ICollection<HrEmpSalaryType> HrEmpSalaryTypes { get; set; }
        [InverseProperty("Emp")]
        public virtual ICollection<MsCheqBook> MsCheqBooks { get; set; }
        [InverseProperty("Emp")]
        public virtual ICollection<ProjProjectItemEmpJoin> ProjProjectItemEmpJoins { get; set; }
        [InverseProperty("Emp")]
        public virtual ICollection<SrEmpServicType> SrEmpServicTypes { get; set; }
        [InverseProperty("Emp")]
        public virtual ICollection<SrTaskEmp> SrTaskEmps { get; set; }
    }
}
