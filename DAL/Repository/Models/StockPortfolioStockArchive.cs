using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Stock_PortfolioStockArchives")]
    public partial class StockPortfolioStockArchive
    {
        [Key]
        public int StockArchivesId { get; set; }
        public int? StockPortJoinId { get; set; }
        public int? StockArchId { get; set; }
        public int? StockQuantity { get; set; }

        [ForeignKey("StockArchId")]
        [InverseProperty("StockPortfolioStockArchives")]
        public virtual StockArchive? StockArch { get; set; }
        [ForeignKey("StockPortJoinId")]
        [InverseProperty("StockPortfolioStockArchives")]
        public virtual StockPortfolioStock? StockPortJoin { get; set; }
    }
}
