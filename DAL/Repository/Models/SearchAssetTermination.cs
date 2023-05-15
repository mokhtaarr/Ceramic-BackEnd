using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchAssetTermination
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public int TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(50)]
        public string? AssetCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public bool? IsProduction { get; set; }
        public int? RemainInstallments { get; set; }
        public int? InstallMentCount { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(20)]
        public string? Fax { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(500)]
        public string? Address { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(50)]
        public string? CatCode { get; set; }
        [StringLength(100)]
        public string? CatDescA { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastDeprDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DeprValue { get; set; }
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
