using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_PostOrder")]
    public partial class CalPostOrder
    {
        [Key]
        public int PostQueId { get; set; }
        public int? AccountId { get; set; }
        public int? CostCenterId { get; set; }
        public bool? IsHelpAcc { get; set; }
        public int? HelpAccId { get; set; }
        [StringLength(50)]
        public string? HelpAccType { get; set; }
        public bool? IsHelpCostCenter { get; set; }
        public int? HelpCostCenterId { get; set; }
        [StringLength(50)]
        public string? HelpCostCenterType { get; set; }
        public int? TermId { get; set; }
        public int? CurrencyId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? OriginalDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [StringLength(100)]
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        public int? DetailedTableEntityId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DebitLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceDepit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalaceLocalBeforDebit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalaceLocalBeforCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceLocalAfterDebit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceLocalAfterCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DebitCurrency { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditCurrency { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceDepitCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceCreditCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalaceCurrencyBeforDebit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalaceCurrencyBeforCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceCurrencyAfterDebit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceCurrencyAfterCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenBalancDepCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenBalancCredCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalancLocalBeforDebCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalancLocalBeforCredCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalancLocalAfterDebCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalancLocalAfterCredCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenBalancDepCrncyCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenBalancCredCrncyCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalancCrencyBeforDebtCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalancCrencyBeforCredCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalancCrencyAftrDebtCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalancCrencyAftrCredCostCentr { get; set; }
        public bool? IsPosted { get; set; }
        public int? OrderId { get; set; }
        public bool? IsOpenningTerm { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
    }
}
