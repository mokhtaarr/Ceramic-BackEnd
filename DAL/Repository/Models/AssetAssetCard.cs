using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Asset_AssetCard")]
    public partial class AssetAssetCard
    {
        public AssetAssetCard()
        {
            AssetAssetContacts = new HashSet<AssetAssetContact>();
            CalAssetAccounts = new HashSet<CalAssetAccount>();
        }

        [Key]
        public int AssetId { get; set; }
        public int? AssetCatId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? CostCenterId3 { get; set; }
        public int? DepartMentId { get; set; }
        public int? StoreId { get; set; }
        public int? CurrentEmpId { get; set; }
        [StringLength(50)]
        public string? AssetCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public bool? NoDepreciation { get; set; }
        public byte? Status { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PurchDate { get; set; }
        [StringLength(50)]
        public string? PurchDoc { get; set; }
        [StringLength(50)]
        public string? VendorDesc { get; set; }
        [StringLength(50)]
        public string? SerialNo { get; set; }
        [StringLength(500)]
        public string? WarrantyTerms { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? WarrantyDate { get; set; }
        [StringLength(50)]
        public string? WarrantyNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InsuranceExpiry { get; set; }
        [StringLength(50)]
        public string? ResponsiblePerson { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MarketPrice { get; set; }
        public byte? Barcode { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PurchPrice { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastDeprDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeprStartDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DeprInstallmentVal { get; set; }
        public int? InstallMentCount { get; set; }
        public int? RemainInstallments { get; set; }
        public byte? DeprMethod { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProductivPeriod { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CurrentBookValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? JunkValue { get; set; }
        public bool? IsProduction { get; set; }
        public int? EquipId { get; set; }
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
        [StringLength(500)]
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
        [StringLength(100)]
        public string? TaxRefNo { get; set; }
        /// <summary>
        /// Business  tax Reg Required,Person   NationalID not required,Foreigner  Name and ID  required
        /// </summary>
        [StringLength(50)]
        public string? EtaxCustType { get; set; }
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

        [ForeignKey("AssetCatId")]
        [InverseProperty("AssetAssetCards")]
        public virtual AssetAssetCategory? AssetCat { get; set; }
        [InverseProperty("Asset")]
        public virtual ICollection<AssetAssetContact> AssetAssetContacts { get; set; }
        [InverseProperty("Asset")]
        public virtual ICollection<CalAssetAccount> CalAssetAccounts { get; set; }
    }
}
