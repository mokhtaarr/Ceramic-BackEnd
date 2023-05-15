using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Stock_CashTransfer")]
    public partial class StockCashTransfer
    {
        [Key]
        public int StockCashTransferId { get; set; }
        public int? StockTranTypId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? FromStockPortfolioId { get; set; }
        public int? AccountIdFrom { get; set; }
        public int? ToStockPortfolioId { get; set; }
        public int? AccountIdTo { get; set; }
        public int? CurrencyId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CurrencyRate { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrTime { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Amount { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
    }
}
