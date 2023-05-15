using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjUnitPerspectiveJoin")]
    [Index("Fsid", Name = "UQ__Proj_Pro__9C4B07177DDE556F", IsUnique = true)]
    public partial class ProjProjUnitPerspectiveJoin
    {
        [Key]
        public int ProjUnitPerspectiveJoinId { get; set; }
        public int? ProjUnitId { get; set; }
        [Column("FSId")]
        public Guid Fsid { get; set; }
        public int? UnitPerspectiveId { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        public string? AttachPath { get; set; }
        [Column("FData")]
        public byte[]? Fdata { get; set; }

        [ForeignKey("ProjUnitId")]
        [InverseProperty("ProjProjUnitPerspectiveJoins")]
        public virtual ProjProjUnit? ProjUnit { get; set; }
        [ForeignKey("UnitPerspectiveId")]
        [InverseProperty("ProjProjUnitPerspectiveJoins")]
        public virtual CodUnitPerspective? UnitPerspective { get; set; }
    }
}
