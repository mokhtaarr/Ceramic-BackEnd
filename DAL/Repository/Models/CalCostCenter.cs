using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_CostCenters")]
    public partial class CalCostCenter
    {
        public CalCostCenter()
        {
            CalCostCenterAccounts = new HashSet<CalCostCenterAccount>();
        }

        [Key]
        public int CostCenterId { get; set; }
        public int? CostCenterCode { get; set; }
        [StringLength(100)]
        public string? CostCenterNameA { get; set; }
        [StringLength(100)]
        public string? CostCenterNameE { get; set; }
        [Column("mainCostCenterId")]
        public int? MainCostCenterId { get; set; }
        public int? CostCenterLevel { get; set; }
        public byte? CenterCategory { get; set; }
        public byte? CostType { get; set; }
        public byte? CashFlowList { get; set; }
        public int? Aid { get; set; }
        public int? AccountId { get; set; }
        public int? CurrencyId { get; set; }
        [StringLength(100)]
        public string? FunctionDescA { get; set; }
        [StringLength(100)]
        public string? FunctionDescE { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PreviousBalance { get; set; }
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
        [StringLength(255)]
        public string? RemarksA { get; set; }
        [StringLength(255)]
        public string? RemarksE { get; set; }
        public int? Parent { get; set; }
        public int? MonthlybalanceId { get; set; }
        [Column("jopDesc")]
        public byte? JopDesc { get; set; }
        public int? BoxId { get; set; }
        public int? AccCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceDepit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostCenterCurrTrancDepit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostCenterCurrTrancCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostCenterTotalDebit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostCenterTotaCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceDebitLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceCreditLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceDepitCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceCreditCurncy { get; set; }
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

        [InverseProperty("CostCenter")]
        public virtual ICollection<CalCostCenterAccount> CalCostCenterAccounts { get; set; }
    }
}
