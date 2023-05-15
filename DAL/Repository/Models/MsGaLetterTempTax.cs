using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MsGA_LetterTempTax")]
    public partial class MsGaLetterTempTax
    {
        [Key]
        public int LetterTaxTempId { get; set; }
        [StringLength(50)]
        public string? TempCode { get; set; }
        [StringLength(100)]
        public string? TempDesca { get; set; }
        [StringLength(100)]
        public string? TempDesce { get; set; }
        [Column(TypeName = "numeric(22, 2)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(7, 2)")]
        public decimal? TaxPercent { get; set; }
        [Column(TypeName = "numeric(22, 2)")]
        public decimal? TaxValu { get; set; }
        public int? Quantity { get; set; }
        public int? QuantityUsed { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
    }
}
