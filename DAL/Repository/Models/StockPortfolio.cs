using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Stock_Portfolio")]
    public partial class StockPortfolio
    {
        public StockPortfolio()
        {
            StockPortfolioAccounts = new HashSet<StockPortfolioAccount>();
            StockPortfolioStocks = new HashSet<StockPortfolioStock>();
        }

        [Key]
        public int StockPortfolioId { get; set; }
        [StringLength(50)]
        public string Code { get; set; } = null!;
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public int? PortfolioNo { get; set; }
        public int? CurrencyId { get; set; }
        public int? StockBrokersId { get; set; }
        public bool? ManagedByOthers { get; set; }
        public bool? FollowOtherPortfolio { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? StockBalance { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InvestBoxBalance { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CashBalance { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalBalance { get; set; }
        [StringLength(255)]
        public string? RemarksA { get; set; }
        [StringLength(255)]
        public string? RemarksE { get; set; }
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

        [InverseProperty("StockPortfolio")]
        public virtual ICollection<StockPortfolioAccount> StockPortfolioAccounts { get; set; }
        [InverseProperty("StockPortfolio")]
        public virtual ICollection<StockPortfolioStock> StockPortfolioStocks { get; set; }
    }
}
