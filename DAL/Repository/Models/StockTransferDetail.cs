using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Stock_TransferDetail")]
    public partial class StockTransferDetail
    {
        [Key]
        public int StockTransferDetailId { get; set; }
        public int StockTransferId { get; set; }
        public int? StockTranTypId { get; set; }
        public int? StockId { get; set; }
        public int? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostAverage { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProfitLoss { get; set; }

        [ForeignKey("StockTransferId")]
        [InverseProperty("StockTransferDetails")]
        public virtual StockTransfer StockTransfer { get; set; } = null!;
    }
}
