using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwsimpleAllTransaction
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
        [StringLength(50)]
        public string? AccountCode { get; set; }
        [StringLength(100)]
        public string? AccountNameA { get; set; }
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
        [StringLength(30)]
        [Unicode(false)]
        public string? RemarksA { get; set; }
    }
}
