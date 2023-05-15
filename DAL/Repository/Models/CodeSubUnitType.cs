using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Code_SubUnitTypes")]
    public partial class CodeSubUnitType
    {
        public CodeSubUnitType()
        {
            ProjProjUnitSubUnits = new HashSet<ProjProjUnitSubUnit>();
        }

        [Key]
        public int SubUnittypeId { get; set; }
        public int Code { get; set; }
        [StringLength(100)]
        public string? DescA { get; set; }
        [StringLength(100)]
        public string? DescE { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public bool? CalcByMeter { get; set; }
        public bool? TotalUnitMeters { get; set; }
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

        [InverseProperty("SubUnittype")]
        public virtual ICollection<ProjProjUnitSubUnit> ProjProjUnitSubUnits { get; set; }
    }
}
