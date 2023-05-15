using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_Equipments")]
    public partial class ProdEquipment
    {
        public ProdEquipment()
        {
            ProdEquipProfiles = new HashSet<ProdEquipProfile>();
        }

        [Key]
        public int EquipId { get; set; }
        [StringLength(50)]
        public string? EquipCode { get; set; }
        [StringLength(100)]
        public string? EquipName1 { get; set; }
        [StringLength(100)]
        public string? EquipName2 { get; set; }
        [Column("JDesc")]
        [StringLength(500)]
        public string? Jdesc { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? StandardMonthlyCost { get; set; }
        public byte? StandardHolyDays { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? StandardDailyCost { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? StandardDailyWorkHours { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? StandardHourlyCost { get; set; }
        public int? NumberAvailable { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TimeRate { get; set; }
        public int? BasUnitId { get; set; }
        [Column(TypeName = "numeric(25, 4)")]
        public decimal? QtyPerUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? IsScale { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MaxWeight { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MinWeight { get; set; }
        [StringLength(500)]
        public string? TechnicalSpecs { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SpeedByHour { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? StandByTime { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MaxWidth { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MaxLength { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MaxHeight { get; set; }
        public int? MinLaborCount { get; set; }
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

        [InverseProperty("Equip")]
        public virtual ICollection<ProdEquipProfile> ProdEquipProfiles { get; set; }
    }
}
