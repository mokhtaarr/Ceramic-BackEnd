using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwAllLetOfGtransaction
    {
        public int LetOfGrnteeTranId { get; set; }
        public int? LetOfGrnteeId { get; set; }
        public int? TrNo { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [StringLength(100)]
        public string? StatusName1 { get; set; }
        [StringLength(100)]
        public string? CategoryName1 { get; set; }
        [StringLength(100)]
        public string? TypeName1 { get; set; }
        [StringLength(50)]
        public string? CurrencyCode { get; set; }
        [StringLength(100)]
        public string? CurrencyDescA { get; set; }
        public bool? DefualtCurrency { get; set; }
        [StringLength(50)]
        public string? CurrencySymbol { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [StringLength(200)]
        public string? LetterOfGuaranteeName1 { get; set; }
        [StringLength(200)]
        public string? LetterOfGuaranteeName2 { get; set; }
        [StringLength(50)]
        public string LetterOfGuaranteeCode { get; set; } = null!;
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ValueBeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Commision { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoverValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Expenses { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LetEndDate { get; set; }
    }
}
