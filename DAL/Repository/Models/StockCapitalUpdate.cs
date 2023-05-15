using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Stock_CapitalUpdate")]
    public partial class StockCapitalUpdate
    {
        [Key]
        public int StockCapitalUpdatId { get; set; }
        public int? StockId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CurrentCapital { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UpdateValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SalePrice { get; set; }
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

        [ForeignKey("StockId")]
        [InverseProperty("StockCapitalUpdates")]
        public virtual StockStock? Stock { get; set; }
    }
}
