using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_AccountChart")]
    public partial class CalAccountChart
    {
        public CalAccountChart()
        {
            CalAccChrtDailyAssists = new HashSet<CalAccChrtDailyAssist>();
            CalAccountClaasiJoins = new HashSet<CalAccountClaasiJoin>();
            CalAccountUsers = new HashSet<CalAccountUser>();
            CalCostCenterAccounts = new HashSet<CalCostCenterAccount>();
            CalEmpAccounts = new HashSet<CalEmpAccount>();
            CodDailyAssistances = new HashSet<CodDailyAssistance>();
            StockPortfolioAccounts = new HashSet<StockPortfolioAccount>();
        }

        [Key]
        public int AccountId { get; set; }
        public long? AccountCode { get; set; }
        [StringLength(100)]
        public string? AccountNameA { get; set; }
        [StringLength(100)]
        public string? AccountNameE { get; set; }
        [Column("mainAccountId")]
        public int? MainAccountId { get; set; }
        public int? AccountLevel { get; set; }
        public byte? AccountType { get; set; }
        public byte? AccountNature { get; set; }
        public byte? AccountGroup { get; set; }
        public byte? AccCashFlow { get; set; }
        public bool? CalcMethod { get; set; }
        public int? CurrencyId { get; set; }
        public int? Aid { get; set; }
        public int? AccBulkAccount { get; set; }
        public int? AccountCategory { get; set; }
        public bool? CostCentersDistribute { get; set; }
        public bool? CurrencyReevaluation { get; set; }
        public bool? AccountStopped { get; set; }
        [StringLength(250)]
        public string? RemarksA { get; set; }
        [StringLength(250)]
        public string? RemarksE { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccApproxim { get; set; }
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
        public byte? CostCenterOption { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public bool? IsServerEntity { get; set; }
        public int? MainServerId { get; set; }

        [ForeignKey("Aid")]
        [InverseProperty("CalAccountCharts")]
        public virtual SysAnalyticalCode? AidNavigation { get; set; }
        [InverseProperty("Account")]
        public virtual ICollection<CalAccChrtDailyAssist> CalAccChrtDailyAssists { get; set; }
        [InverseProperty("Account")]
        public virtual ICollection<CalAccountClaasiJoin> CalAccountClaasiJoins { get; set; }
        [InverseProperty("Account")]
        public virtual ICollection<CalAccountUser> CalAccountUsers { get; set; }
        [InverseProperty("Account")]
        public virtual ICollection<CalCostCenterAccount> CalCostCenterAccounts { get; set; }
        [InverseProperty("Account")]
        public virtual ICollection<CalEmpAccount> CalEmpAccounts { get; set; }
        [InverseProperty("Account")]
        public virtual ICollection<CodDailyAssistance> CodDailyAssistances { get; set; }
        [InverseProperty("Account")]
        public virtual ICollection<StockPortfolioAccount> StockPortfolioAccounts { get; set; }
    }
}
