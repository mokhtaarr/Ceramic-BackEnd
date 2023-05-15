using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Stock_SalesPurchaseDetails")]
    public partial class StockSalesPurchaseDetail
    {
        [Key]
        public int StockSalPurchDetailId { get; set; }
        public int? StockSalPurchId { get; set; }
        public int? StockTranTypId { get; set; }
        public int? StockDealersId { get; set; }
        public int? DealNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DealTime { get; set; }
        public int? StockId { get; set; }
        public int? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FixedCommision { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OtherCommision { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetValue { get; set; }

        [ForeignKey("StockSalPurchId")]
        [InverseProperty("StockSalesPurchaseDetails")]
        public virtual StockSalesPurchase? StockSalPurch { get; set; }
    }
}
