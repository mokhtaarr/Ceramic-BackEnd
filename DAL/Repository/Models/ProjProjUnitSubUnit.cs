using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjUnitSubUnits")]
    public partial class ProjProjUnitSubUnit
    {
        [Key]
        public int SubUnitId { get; set; }
        public int ProjUnitId { get; set; }
        public int SubUnittypeId { get; set; }
        public bool? CalcByMeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MetersCount { get; set; }
        public int? CurrencyId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MeterPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrice { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        [StringLength(100)]
        public string? RemarksA { get; set; }
        [StringLength(100)]
        public string? RemarksE { get; set; }

        [ForeignKey("ProjUnitId")]
        [InverseProperty("ProjProjUnitSubUnits")]
        public virtual ProjProjUnit ProjUnit { get; set; } = null!;
        [ForeignKey("SubUnittypeId")]
        [InverseProperty("ProjProjUnitSubUnits")]
        public virtual CodeSubUnitType SubUnittype { get; set; } = null!;
    }
}
