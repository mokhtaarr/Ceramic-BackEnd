using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_BusinessPartnerAccounts")]
    public partial class CalBusinessPartnerAccount
    {
        [Key]
        public int BusinessPartnerAccId { get; set; }
        [Column("BSPartnerId")]
        public int? BspartnerId { get; set; }
        [StringLength(100)]
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        public int? AccountId { get; set; }
        [StringLength(100)]
        public string? AccountCode { get; set; }
        [StringLength(100)]
        public string? AccountNameA { get; set; }
        [StringLength(100)]
        public string? AccountNameE { get; set; }
        public bool? AccountStopped { get; set; }
        /// <summary>
        /// discount, tax, master ...etc
        /// </summary>
        [StringLength(100)]
        public string? AccountModel { get; set; }
        [StringLength(250)]
        public string? RemarksA { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceDepit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccCurrTrancDepit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccCurrTrancCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccTotalDebit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccTotaCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceDebitLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceCreditLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceDepitCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceCreditCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccCurrTrancDepitCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccCurrTrancCreditCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccTotalDebitCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccTotaCreditCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceDebitCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceCreditCurncy { get; set; }
        public bool? IsPrimeAccount { get; set; }
        public bool? IsInUse { get; set; }
        [StringLength(100)]
        public string? AccountDescription { get; set; }
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
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("BspartnerId")]
        [InverseProperty("CalBusinessPartnerAccounts")]
        public virtual MsBusinessPartner? Bspartner { get; set; }
    }
}
