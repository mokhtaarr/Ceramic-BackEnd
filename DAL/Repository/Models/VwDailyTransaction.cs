using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwDailyTransaction
    {
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(151)]
        public string? CustomerCode { get; set; }
        [StringLength(200)]
        public string? CustomerDescA { get; set; }
        [StringLength(303)]
        public string? Remarks { get; set; }
        [StringLength(50)]
        public string? PrefixCode { get; set; }
        [Column("BookNameAR")]
        [StringLength(100)]
        public string? BookNameAr { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public bool? IsOpenningTerm { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column("IDname")]
        [StringLength(16)]
        [Unicode(false)]
        public string Idname { get; set; } = null!;
        [StringLength(22)]
        [Unicode(false)]
        public string SourcTyp { get; set; } = null!;
        [StringLength(151)]
        public string? SourceCode { get; set; }
        [StringLength(200)]
        public string? SourceName { get; set; }
        [StringLength(50)]
        public string? AnalizCode { get; set; }
        [StringLength(100)]
        public string? AnalizName1 { get; set; }
        [StringLength(100)]
        public string? AnalizName2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [StringLength(50)]
        public string? CurrencyCode { get; set; }
        [StringLength(100)]
        public string? CurrencyDescA { get; set; }
        [StringLength(100)]
        public string? CurrencyDescE { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string DocType { get; set; } = null!;
        [Column("DocTypeAR")]
        [StringLength(14)]
        [Unicode(false)]
        public string DocTypeAr { get; set; } = null!;
        public int? StoreId { get; set; }
    }
}
