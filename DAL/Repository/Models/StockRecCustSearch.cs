using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class StockRecCustSearch
    {
        public int TrNo { get; set; }
        public int? StoreId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(50)]
        public string CustomerCode { get; set; } = null!;
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        public int StockRecId { get; set; }
        public int? BookId { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public bool? CostExecuted { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ReceiptrQty { get; set; }
        [Column("strCustm4")]
        [StringLength(100)]
        public string? StrCustm4 { get; set; }
        [Column("strCustm5")]
        [StringLength(100)]
        public string? StrCustm5 { get; set; }
    }
}
