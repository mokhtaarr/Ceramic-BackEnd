using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwAllCostCenterTransaction
    {
        public int PostQueId { get; set; }
        public int? CostCenterId { get; set; }
        public bool? IsHelpCostCenter { get; set; }
        [StringLength(50)]
        public string? HelpCostCenterType { get; set; }
        public int? TermId { get; set; }
        public int? CurrencyId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [StringLength(100)]
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DebitLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DebitCurrency { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditCurrency { get; set; }
        public bool? IsPosted { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(151)]
        public string? CustomerCode { get; set; }
        [StringLength(200)]
        public string? CustomerDescA { get; set; }
        public int? CostCenterCode { get; set; }
        [StringLength(100)]
        public string? CostCenterNameA { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceDepitCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceCreditCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceDepit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostCenterCurrTrancDepit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostCenterTotaCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceDebitLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceCreditLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostCenterCurrTrancDepitCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostCenterCurrTrancCreditCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostCenterTotalDebitCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostCenterTotaCreditCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceDebitCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceCreditCurncy { get; set; }
        public int? CustomerId { get; set; }
        [StringLength(50)]
        public string CurrencyCode { get; set; } = null!;
        [StringLength(100)]
        public string? CurrencyDescA { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostCenterTotalDebit { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceLocalAfterDebit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceLocalAfterCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceCurrencyAfterDebit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceCurrencyAfterCredit { get; set; }
        public bool? IsOpenning { get; set; }
        public bool? DefualtCurrency { get; set; }
        [StringLength(50)]
        public string? PrefixCode { get; set; }
        [Column("BookNameAR")]
        [StringLength(100)]
        public string? BookNameAr { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
    }
}
