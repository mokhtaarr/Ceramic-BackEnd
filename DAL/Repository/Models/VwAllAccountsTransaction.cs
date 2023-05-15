using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwAllAccountsTransaction
    {
        public int PostQueId { get; set; }
        public int? AccountId { get; set; }
        public bool? IsHelpAcc { get; set; }
        [StringLength(50)]
        public string? HelpAccType { get; set; }
        public int? HelpAccId { get; set; }
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
        [StringLength(100)]
        public string? AccountCode { get; set; }
        [StringLength(100)]
        public string? AccountNameA { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceDepitCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceCreditCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceDepit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccCurrTrancDepit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccTotaCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceDebitLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceCreditLocal { get; set; }
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
        public int? CustomerId { get; set; }
        [StringLength(50)]
        public string CurrencyCode { get; set; } = null!;
        [StringLength(100)]
        public string? CurrencyDescA { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccTotalDebit { get; set; }
        [StringLength(303)]
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
        public bool? CalcMethod { get; set; }
        public bool? DefualtCurrency { get; set; }
        [StringLength(50)]
        public string? PrefixCode { get; set; }
        [Column("BookNameAR")]
        [StringLength(100)]
        public string? BookNameAr { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public bool? IsOpenningTerm { get; set; }
        public int? AccountCurrencyId { get; set; }
        public byte? AccountBranching { get; set; }
        public byte? AccountGroup { get; set; }
        public byte? AccountNature { get; set; }
        public byte? AccCashFlow { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public long? ChrtAccountCode { get; set; }
        [Column("IDname")]
        [StringLength(16)]
        [Unicode(false)]
        public string Idname { get; set; } = null!;
        [StringLength(33)]
        [Unicode(false)]
        public string SourcTyp { get; set; } = null!;
        [StringLength(151)]
        public string? SourceCode { get; set; }
        [StringLength(200)]
        public string? SourceName { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? RemarksA { get; set; }
        [StringLength(50)]
        public string? AnalizCode { get; set; }
        [StringLength(100)]
        public string? AnalizName1 { get; set; }
        [StringLength(100)]
        public string? AnalizName2 { get; set; }
        [StringLength(50)]
        public string? CheckNumber { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        public int? ShiftId { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [StringLength(50)]
        public string? ManualTrNo { get; set; }
        public int? StoreId { get; set; }
        [StringLength(50)]
        public string? StoreCode { get; set; }
        [StringLength(100)]
        public string? StoreDescA { get; set; }
    }
}
