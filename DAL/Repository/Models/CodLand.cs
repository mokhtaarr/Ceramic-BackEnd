using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cod_Lands")]
    public partial class CodLand
    {
        public CodLand()
        {
            CodLandPermitActivJoins = new HashSet<CodLandPermitActivJoin>();
            CodLandPosJoins = new HashSet<CodLandPosJoin>();
            CodLandRetainResJoins = new HashSet<CodLandRetainResJoin>();
        }

        [Key]
        public int LandId { get; set; }
        public int Code { get; set; }
        [StringLength(100)]
        public string? DescA { get; set; }
        [StringLength(100)]
        public string? DescE { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        [StringLength(200)]
        public string? LandNo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Landarea { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BuildingArea { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LandMeterPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BuildingMeterPrice { get; set; }
        public int? LandSatusId { get; set; }
        public int? LandTypeId { get; set; }
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
        [StringLength(255)]
        public string? RemarksA { get; set; }
        [StringLength(255)]
        public string? RemarksE { get; set; }

        [InverseProperty("Land")]
        public virtual ICollection<CodLandPermitActivJoin> CodLandPermitActivJoins { get; set; }
        [InverseProperty("Land")]
        public virtual ICollection<CodLandPosJoin> CodLandPosJoins { get; set; }
        [InverseProperty("Land")]
        public virtual ICollection<CodLandRetainResJoin> CodLandRetainResJoins { get; set; }
    }
}
