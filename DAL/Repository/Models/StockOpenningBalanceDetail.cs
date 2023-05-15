using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Stock_OpenningBalanceDetails")]
    public partial class StockOpenningBalanceDetail
    {
        [Key]
        public int StockOpenDetailId { get; set; }
        public int? StockOpenId { get; set; }
        public int? StockId { get; set; }
        public int? StockCurrencyId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CurrencyRate { get; set; }
        public int? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPriceLocal { get; set; }

        [ForeignKey("StockOpenId")]
        [InverseProperty("StockOpenningBalanceDetails")]
        public virtual StockOpenningBalance? StockOpen { get; set; }
    }
}
