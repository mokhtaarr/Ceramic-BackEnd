using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_CostCenterAccount")]
    public partial class CalCostCenterAccount
    {
        [Key]
        public int CostCenterAccId { get; set; }
        public int? CostCenterId { get; set; }
        public int? AccountId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccountPercent { get; set; }
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

        [ForeignKey("AccountId")]
        [InverseProperty("CalCostCenterAccounts")]
        public virtual CalAccountChart? Account { get; set; }
        [ForeignKey("CostCenterId")]
        [InverseProperty("CalCostCenterAccounts")]
        public virtual CalCostCenter? CostCenter { get; set; }
    }
}
