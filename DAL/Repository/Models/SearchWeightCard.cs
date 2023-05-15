using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchWeightCard
    {
        public int? StoreId { get; set; }
        public int TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeightQty1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeightQty2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeightQtyDiff { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Weight1Date { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Weight2Date { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        public int ScaleCardId { get; set; }
        [StringLength(500)]
        public string? Remarks1 { get; set; }
        public int? BookId { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
    }
}
