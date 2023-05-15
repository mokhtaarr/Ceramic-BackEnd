using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Print_QoutationDetailsItems")]
    public partial class PrintQoutationDetailsItem
    {
        [Key]
        public int PrintQoutItemId { get; set; }
        public int PrinQoutDetailId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Length { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Width { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalDimension { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        [StringLength(200)]
        public string? Remarks4 { get; set; }

        [ForeignKey("PrinQoutDetailId")]
        [InverseProperty("PrintQoutationDetailsItems")]
        public virtual PrintQoutationDetail PrinQoutDetail { get; set; } = null!;
    }
}
