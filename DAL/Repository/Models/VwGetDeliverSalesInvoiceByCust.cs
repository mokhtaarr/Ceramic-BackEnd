using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetDeliverSalesInvoiceByCust
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(50)]
        public string? PrefixCode { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(50)]
        public string CustomerCode { get; set; } = null!;
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCostAverage { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalLastCost { get; set; }
        [StringLength(8)]
        [Unicode(false)]
        public string IsCust { get; set; } = null!;
        public int DeliverId { get; set; }
        public int? BookId { get; set; }
        public int? StoreId { get; set; }
    }
}
