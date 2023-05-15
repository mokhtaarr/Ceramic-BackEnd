using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_Vendor")]
    public partial class MsVendor
    {
        public MsVendor()
        {
            CalVendAccounts = new HashSet<CalVendAccount>();
            MsItemVendors = new HashSet<MsItemVendor>();
            MsVendImgs = new HashSet<MsVendImg>();
            MsVendorBranches = new HashSet<MsVendorBranch>();
            MsVendorContacts = new HashSet<MsVendorContact>();
            MsVendorUsers = new HashSet<MsVendorUser>();
            ProjProjectItemsVendors = new HashSet<ProjProjectItemsVendor>();
        }

        [Key]
        public int VendorId { get; set; }
        public int? VendorCatId { get; set; }
        public int? VendorTypeId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CostCenterId { get; set; }
        [StringLength(50)]
        public string VendorCode { get; set; } = null!;
        [StringLength(100)]
        public string? VendorDescA { get; set; }
        [StringLength(100)]
        public string? VendorDescE { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTaxExempted { get; set; }
        public byte? CreditPeriodType { get; set; }
        public int? CreditPeriod { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditLimit { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(20)]
        public string? Tel2 { get; set; }
        [StringLength(20)]
        public string? Tel3 { get; set; }
        [StringLength(20)]
        public string? Tel4 { get; set; }
        [StringLength(20)]
        public string? Tel5 { get; set; }
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
        [StringLength(100)]
        public string? Address { get; set; }
        [StringLength(100)]
        public string? Address1 { get; set; }
        [StringLength(100)]
        public string? Address2 { get; set; }
        [StringLength(100)]
        public string? Address3 { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
        [StringLength(100)]
        public string? AddField3 { get; set; }
        [StringLength(100)]
        public string? AddField4 { get; set; }
        [StringLength(100)]
        public string? AddField5 { get; set; }
        public byte? Barcode { get; set; }
        public bool? ForAdjustOnly { get; set; }
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
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? CityId { get; set; }
        public int? EmpId { get; set; }
        public int? StoreId { get; set; }
        public int? TaxesId1 { get; set; }
        public int? TaxesId2 { get; set; }
        public int? TaxesId3 { get; set; }
        public bool? IsBlocked { get; set; }
        public bool? IsCreditEnabled { get; set; }
        public bool? IsPricIncludTax { get; set; }
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
        [Column("dtReg", TypeName = "smalldatetime")]
        public DateTime? DtReg { get; set; }
        [Column("dtRegRenew", TypeName = "smalldatetime")]
        public DateTime? DtRegRenew { get; set; }
        [StringLength(100)]
        public string? Company { get; set; }
        [StringLength(100)]
        public string? VendJob { get; set; }
        [Column("VendID")]
        [StringLength(100)]
        public string? VendId { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public bool? IsServerEntity { get; set; }
        public int? MainServerId { get; set; }
        [Column(TypeName = "numeric(10, 2)")]
        public decimal? Evaluation { get; set; }

        [ForeignKey("CurrencyId")]
        [InverseProperty("MsVendors")]
        public virtual MsCurrency? Currency { get; set; }
        [ForeignKey("VendorCatId")]
        [InverseProperty("MsVendors")]
        public virtual MsVendorCategory? VendorCat { get; set; }
        [ForeignKey("VendorTypeId")]
        [InverseProperty("MsVendors")]
        public virtual MsVendorType? VendorType { get; set; }
        [InverseProperty("Vendor")]
        public virtual ICollection<CalVendAccount> CalVendAccounts { get; set; }
        [InverseProperty("Vendor")]
        public virtual ICollection<MsItemVendor> MsItemVendors { get; set; }
        [InverseProperty("Vendor")]
        public virtual ICollection<MsVendImg> MsVendImgs { get; set; }
        [InverseProperty("Vendor")]
        public virtual ICollection<MsVendorBranch> MsVendorBranches { get; set; }
        [InverseProperty("Vendor")]
        public virtual ICollection<MsVendorContact> MsVendorContacts { get; set; }
        [InverseProperty("Vendor")]
        public virtual ICollection<MsVendorUser> MsVendorUsers { get; set; }
        [InverseProperty("Vendor")]
        public virtual ICollection<ProjProjectItemsVendor> ProjProjectItemsVendors { get; set; }
    }
}
