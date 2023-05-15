using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchItemStockAdjustment
    {
        public int? StorId { get; set; }
        public int? StorePartId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? StockTotalCost { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [StringLength(50)]
        public string PartCode { get; set; } = null!;
        [StringLength(100)]
        public string? PartDescA { get; set; }
        [StringLength(50)]
        public string? PartDescE { get; set; }
        [StringLength(50)]
        public string StoreCode { get; set; } = null!;
        [StringLength(100)]
        public string? StoreDescA { get; set; }
        [StringLength(100)]
        public string? StoreDescE { get; set; }
        public int StockAdjustId { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public bool? IsStockOpenning { get; set; }
        public bool? IsReevaluation { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
    }
}
