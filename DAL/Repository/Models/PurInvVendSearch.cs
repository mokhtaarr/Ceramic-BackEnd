using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class PurInvVendSearch
    {
        public int? StorId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetPrice { get; set; }
        [StringLength(50)]
        public string? VendorCode { get; set; }
        [StringLength(100)]
        public string? VendorDescA { get; set; }
        [StringLength(100)]
        public string? InvDescA { get; set; }
        [StringLength(100)]
        public string? InvDescE { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        public int PurInvId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        public int? CurrencyId { get; set; }
        [StringLength(50)]
        public string? CurrencyCode { get; set; }
        [StringLength(100)]
        public string? CurrencyDescA { get; set; }
        [StringLength(100)]
        public string? CurrencyDescE { get; set; }
        public bool? DefualtCurrency { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        [StringLength(151)]
        public string? PurOrderDocTrNo { get; set; }
    }
}
