using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class PayNoteSearch
    {
        public int TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? StoreId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidPrice { get; set; }
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(200)]
        public string? CustomerDescA { get; set; }
        [StringLength(200)]
        public string? CustomerDescE { get; set; }
        [StringLength(50)]
        public string? CheckNumber { get; set; }
        [Column("cc")]
        public int Cc { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ValueBeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value1BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value2BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value3BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value4 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value4BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value5 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value5BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value6 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value6BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value7 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value7BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value8 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value8BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value9 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value9BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value10 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value10BeforeRate { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [StringLength(50)]
        public string? CurrencyCode { get; set; }
        [StringLength(100)]
        public string? CurrencyDescA { get; set; }
        [StringLength(100)]
        public string? CurrencyDescE { get; set; }
        public int PayId { get; set; }
        public int? BankNoticId { get; set; }
        public int? BankNoticeTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BankNoticeTrDate { get; set; }
        [StringLength(50)]
        public string? BoxCode { get; set; }
        [Column("DESCA")]
        [StringLength(100)]
        public string? Desca { get; set; }
        public int? CurrencyId { get; set; }
        public bool? DefualtCurrency { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public byte? RectSourceType { get; set; }
        public int? VendorId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        public int? RectId { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? AddField3 { get; set; }
        [StringLength(100)]
        public string? AddField4 { get; set; }
        [StringLength(100)]
        public string? AddField5 { get; set; }
        [StringLength(100)]
        public string? AddField6 { get; set; }
    }
}
