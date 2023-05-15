using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Stock_Stocks")]
    public partial class StockStock
    {
        public StockStock()
        {
            StockCapitalUpdates = new HashSet<StockCapitalUpdate>();
            StockPortfolioStocks = new HashSet<StockPortfolioStock>();
        }

        [Key]
        public int StockId { get; set; }
        [StringLength(50)]
        public string Code { get; set; } = null!;
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(20)]
        public string? Symbol { get; set; }
        [StringLength(20)]
        public string? SymbolAr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SharePercent { get; set; }
        public int? StockMarketId { get; set; }
        public int? StockSectorsId { get; set; }
        public int? StockCatId { get; set; }
        public int? CurrencyId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FinancialEndDate { get; set; }
        public bool? Listed { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? StockPrice { get; set; }
        [StringLength(100)]
        public string? ZakatOnInvest { get; set; }
        [StringLength(100)]
        public string? IslamicCompatibility { get; set; }
        [StringLength(100)]
        public string? DocType { get; set; }
        [StringLength(20)]
        public string? Phone1 { get; set; }
        [StringLength(20)]
        public string? Phone2 { get; set; }
        [StringLength(20)]
        public string? Fax { get; set; }
        [StringLength(100)]
        public string? WebSite { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        [StringLength(100)]
        public string? Email { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastMemberDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? NextMemberDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EstablishDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? MarketListDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidCapital { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? StockNameValue { get; set; }
        public int? StockIssuesNo { get; set; }
        public int? StockCurrentNo { get; set; }
        public int? StockTreasuryNo { get; set; }
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

        [ForeignKey("StockCatId")]
        [InverseProperty("StockStocks")]
        public virtual StockCategory? StockCat { get; set; }
        [ForeignKey("StockMarketId")]
        [InverseProperty("StockStocks")]
        public virtual StockMarket? StockMarket { get; set; }
        [ForeignKey("StockSectorsId")]
        [InverseProperty("StockStocks")]
        public virtual StockSector? StockSectors { get; set; }
        [InverseProperty("Stock")]
        public virtual ICollection<StockCapitalUpdate> StockCapitalUpdates { get; set; }
        [InverseProperty("Stock")]
        public virtual ICollection<StockPortfolioStock> StockPortfolioStocks { get; set; }
    }
}
