using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_Customer")]
    public partial class MsCustomer
    {
        public MsCustomer()
        {
            CalCustAccounts = new HashSet<CalCustAccount>();
            LaLands = new HashSet<LaLand>();
            LaPropSerials = new HashSet<LaPropSerial>();
            MsCusromerUsers = new HashSet<MsCusromerUser>();
            MsCustImgs = new HashSet<MsCustImg>();
            MsCustomerBranches = new HashSet<MsCustomerBranch>();
            MsCustomerContacts = new HashSet<MsCustomerContact>();
            MsCustomersFollowUps = new HashSet<MsCustomersFollowUp>();
        }

        [Key]
        public int CustomerId { get; set; }
        public int? CustomerCatId { get; set; }
        public int? CustomerTypeId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CityId { get; set; }
        public int? EmpId { get; set; }
        public int? CostCenterId { get; set; }
        [StringLength(50)]
        public string CustomerCode { get; set; } = null!;
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(100)]
        public string? CustomerDescE { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTaxExempted { get; set; }
        public int? CreditPeriod { get; set; }
        /// <summary>
        /// 1 day, 2 month, 3 year
        /// </summary>
        public byte? PeriodType { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditLimit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditLimitAllowed { get; set; }
        [StringLength(50)]
        public string? Nationality { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(20)]
        public string? Fax { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Email2 { get; set; }
        [StringLength(50)]
        public string? Email3 { get; set; }
        [StringLength(50)]
        public string? Email4 { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        [StringLength(200)]
        public string? Address1 { get; set; }
        [StringLength(200)]
        public string? Address2 { get; set; }
        [StringLength(200)]
        public string? Address3 { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(20)]
        public string? Tel2 { get; set; }
        [StringLength(20)]
        public string? Tel3 { get; set; }
        [StringLength(20)]
        public string? Tel4 { get; set; }
        [StringLength(20)]
        public string? Tel5 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DateOfBirth { get; set; }
        [StringLength(50)]
        public string? PassPortNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PassPortIssueDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PassPortExpiryDate { get; set; }
        [StringLength(50)]
        public string? PassPortIssuePlace { get; set; }
        public bool? InternationalLicense { get; set; }
        [StringLength(50)]
        public string? CarLicenseNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CarLicenseIssueDate { get; set; }
        [StringLength(50)]
        public string? CarLicenseIssuePlace { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CarLicenseExpiryDate { get; set; }
        [Column("dtReg", TypeName = "smalldatetime")]
        public DateTime? DtReg { get; set; }
        [Column("dtRegRenew", TypeName = "smalldatetime")]
        public DateTime? DtRegRenew { get; set; }
        [StringLength(100)]
        public string? Company { get; set; }
        [StringLength(100)]
        public string? CustJob { get; set; }
        [Column("CustID")]
        [StringLength(100)]
        public string? CustId { get; set; }
        public byte? Barcode { get; set; }
        public byte? SalPrice { get; set; }
        [StringLength(255)]
        public string? AddField1 { get; set; }
        [StringLength(255)]
        public string? AddField2 { get; set; }
        [StringLength(255)]
        public string? AddField3 { get; set; }
        [StringLength(255)]
        public string? AddField4 { get; set; }
        [StringLength(255)]
        public string? AddField5 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DefaultDisc { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ReportDiscValu { get; set; }
        public bool? DiscPercentOrVal { get; set; }
        public bool? ForAdjustOnly { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? StoreId { get; set; }
        public int? TaxesId1 { get; set; }
        public int? TaxesId2 { get; set; }
        public int? TaxesId3 { get; set; }
        public bool? IsDiscountByItem { get; set; }
        public bool? IsBlocked { get; set; }
        public bool? IsCreditEnabled { get; set; }
        public bool? IsPricIncludTax { get; set; }
        public bool? IsDealer { get; set; }
        [StringLength(50)]
        public string? TaxExemptionNo { get; set; }
        [StringLength(100)]
        public string? TaxRefNo { get; set; }
        /// <summary>
        /// Business  tax Reg Required,Person   NationalID not required,Foreigner  Name and ID  required
        /// </summary>
        [StringLength(50)]
        public string? EtaxCustType { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? PrePaidPercent { get; set; }
        [StringLength(20)]
        public string? PostalCode { get; set; }
        [StringLength(300)]
        public string? HomePage { get; set; }
        public byte? InvoiceCopies { get; set; }
        public bool? IsTaxInvHold { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal? Evaluation { get; set; }
        public bool? LegalAssign { get; set; }
        [StringLength(500)]
        public string? LegalStatus { get; set; }
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
        public byte[]? LastUpdateTime { get; set; }
        public bool? IsServerEntity { get; set; }
        public int? MainServerId { get; set; }

        [ForeignKey("CurrencyId")]
        [InverseProperty("MsCustomers")]
        public virtual MsCurrency? Currency { get; set; }
        [ForeignKey("CustomerCatId")]
        [InverseProperty("MsCustomers")]
        public virtual MsCustomerCategory? CustomerCat { get; set; }
        [ForeignKey("CustomerTypeId")]
        [InverseProperty("MsCustomers")]
        public virtual MsCustomerType? CustomerType { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<CalCustAccount> CalCustAccounts { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<LaLand> LaLands { get; set; }
        [InverseProperty("CustMainNavigation")]
        public virtual ICollection<LaPropSerial> LaPropSerials { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<MsCusromerUser> MsCusromerUsers { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<MsCustImg> MsCustImgs { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<MsCustomerBranch> MsCustomerBranches { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<MsCustomerContact> MsCustomerContacts { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<MsCustomersFollowUp> MsCustomersFollowUps { get; set; }
    }
}
