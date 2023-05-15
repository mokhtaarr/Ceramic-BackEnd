using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchBoxTransferNote
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public int TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [Column("strCustm1")]
        [StringLength(100)]
        public string? StrCustm1 { get; set; }
        [Column("strCustm2")]
        [StringLength(100)]
        public string? StrCustm2 { get; set; }
        public bool? IsBox { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
    }
}
