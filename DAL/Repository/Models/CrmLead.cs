using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("CRM_Leads")]
    public partial class CrmLead
    {
        public CrmLead()
        {
            CrmLeadsMembersJoins = new HashSet<CrmLeadsMembersJoin>();
        }

        [Key]
        public int LeadId { get; set; }
        public int? LeadTypeId { get; set; }
        public int? CityId { get; set; }
        public int? RegionId { get; set; }
        public int? StoreId { get; set; }
        public int? MarketChannelId { get; set; }
        public bool? IsOpportunity { get; set; }
        public bool? IsCustomer { get; set; }
        public int? CustomerId { get; set; }
        [StringLength(50)]
        public string LeadCode { get; set; } = null!;
        [StringLength(100)]
        public string? LeadName1 { get; set; }
        [StringLength(100)]
        public string? LeadName2 { get; set; }
        public int? AssignedToEmpId { get; set; }
        [StringLength(200)]
        public string? FormerProduct { get; set; }
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
        public int? TaxesId1 { get; set; }
        public int? TaxesId2 { get; set; }
        public int? TaxesId3 { get; set; }
        public bool? IsDiscountByItem { get; set; }
        public bool? IsBlocked { get; set; }
        public bool? IsCreditEnabled { get; set; }
        public bool? IsPricIncludTax { get; set; }
        [StringLength(50)]
        public string? TaxExemptionNo { get; set; }
        [StringLength(50)]
        public string? TaxRefNo { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? PrePaidPercent { get; set; }
        [StringLength(20)]
        public string? PostalCode { get; set; }
        [StringLength(300)]
        public string? HomePage { get; set; }
        public byte? InvoiceCopies { get; set; }
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

        [ForeignKey("LeadTypeId")]
        [InverseProperty("CrmLeads")]
        public virtual CrmLeadType? LeadType { get; set; }
        [ForeignKey("MarketChannelId")]
        [InverseProperty("CrmLeads")]
        public virtual CrmMarketChannel? MarketChannel { get; set; }
        [InverseProperty("Lead")]
        public virtual ICollection<CrmLeadsMembersJoin> CrmLeadsMembersJoins { get; set; }
    }
}
