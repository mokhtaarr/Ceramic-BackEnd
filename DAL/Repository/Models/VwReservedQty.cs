using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwReservedQty
    {
        [Column(TypeName = "numeric(38, 10)")]
        public decimal Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal QuantityOut { get; set; }
        [Column("reserved", TypeName = "numeric(38, 10)")]
        public decimal? Reserved { get; set; }
        [StringLength(50)]
        public string? ItemCode { get; set; }
        [StringLength(100)]
        public string? ItemDescA { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(100)]
        public string? StoreDescA { get; set; }
    }
}
