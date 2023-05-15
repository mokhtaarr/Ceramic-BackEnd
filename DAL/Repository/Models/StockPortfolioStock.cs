using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Stock_PortfolioStocks")]
    public partial class StockPortfolioStock
    {
        public StockPortfolioStock()
        {
            StockPortfolioStockArchives = new HashSet<StockPortfolioStockArchive>();
        }

        [Key]
        public int StockPortJoinId { get; set; }
        public int? StockPortfolioId { get; set; }
        public int? StockId { get; set; }
        public int? StockQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostAverage { get; set; }

        [ForeignKey("StockId")]
        [InverseProperty("StockPortfolioStocks")]
        public virtual StockStock? Stock { get; set; }
        [ForeignKey("StockPortfolioId")]
        [InverseProperty("StockPortfolioStocks")]
        public virtual StockPortfolio? StockPortfolio { get; set; }
        [InverseProperty("StockPortJoin")]
        public virtual ICollection<StockPortfolioStockArchive> StockPortfolioStockArchives { get; set; }
    }
}
