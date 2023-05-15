using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Stock_PortfolioAccounts")]
    public partial class StockPortfolioAccount
    {
        [Key]
        public int StockPortAccountsId { get; set; }
        public int? StockPortfolioId { get; set; }
        public int? AccountId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalance { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CurrentBalance { get; set; }
        public bool? Auto { get; set; }
        public bool? NoTranEffect { get; set; }

        [ForeignKey("AccountId")]
        [InverseProperty("StockPortfolioAccounts")]
        public virtual CalAccountChart? Account { get; set; }
        [ForeignKey("StockPortfolioId")]
        [InverseProperty("StockPortfolioAccounts")]
        public virtual StockPortfolio? StockPortfolio { get; set; }
    }
}
