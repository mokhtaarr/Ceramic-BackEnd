using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchAdjustMent
    {
        public int TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(31)]
        [Unicode(false)]
        public string AdjustType { get; set; } = null!;
        [StringLength(19)]
        [Unicode(false)]
        public string AdjustSourceType { get; set; } = null!;
        [StringLength(100)]
        public string? AdjustSourceName { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value { get; set; }
        [StringLength(100)]
        public string? StoreDescA { get; set; }
        public int? StoreId { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
    }
}
