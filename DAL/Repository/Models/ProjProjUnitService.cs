using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjUnitService")]
    public partial class ProjProjUnitService
    {
        [Key]
        public int ProjUnitServiceId { get; set; }
        public int? ReservId { get; set; }
        public int? UnitServId { get; set; }
        public int? ProjUnitId { get; set; }
        public byte? PeriodType { get; set; }
        public byte? PeriodRepeat { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ServiceValue { get; set; }
        public bool? PerUnitOrMeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MeterCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalServiceValue { get; set; }
        public bool? Installed { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }

        [ForeignKey("ProjUnitId")]
        [InverseProperty("ProjProjUnitServices")]
        public virtual ProjProjUnit? ProjUnit { get; set; }
        [ForeignKey("ReservId")]
        [InverseProperty("ProjProjUnitServices")]
        public virtual ProjUnitReservation? Reserv { get; set; }
        [ForeignKey("UnitServId")]
        [InverseProperty("ProjProjUnitServices")]
        public virtual CodUnitService? UnitServ { get; set; }
    }
}
