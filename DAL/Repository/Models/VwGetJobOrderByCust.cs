using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetJobOrderByCust
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(50)]
        public string? PrefixCode { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(50)]
        public string CustomerCode { get; set; } = null!;
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CustomerCharged { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalJpbOrder { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        public int JobOrderId { get; set; }
        public int? BookId { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
    }
}
