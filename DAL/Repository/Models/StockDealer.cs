using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Stock_Dealers")]
    public partial class StockDealer
    {
        [Key]
        public int StockDealersId { get; set; }
        [StringLength(50)]
        public string Code { get; set; } = null!;
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(20)]
        public string? Phone1 { get; set; }
        [StringLength(20)]
        public string? Phone2 { get; set; }
        [Column("FAX")]
        [StringLength(20)]
        public string? Fax { get; set; }
        [StringLength(255)]
        public string? Address { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BrokerPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MarketFixedPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MarketOtherPercent { get; set; }
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
    }
}
