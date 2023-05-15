using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjPerspectiveJoin")]
    [Index("Fsid", Name = "UQ__Proj_Pro__9C4B07178AD73A3B", IsUnique = true)]
    public partial class ProjProjPerspectiveJoin
    {
        [Key]
        public int ProjPerspectiveJoinId { get; set; }
        public int? ProjectId { get; set; }
        [Column("FSId")]
        public Guid Fsid { get; set; }
        public int? BuildPerspectiveId { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        public string? AttachPath { get; set; }
        [Column("FData")]
        public byte[]? Fdata { get; set; }

        [ForeignKey("BuildPerspectiveId")]
        [InverseProperty("ProjProjPerspectiveJoins")]
        public virtual CodBuildPerspective? BuildPerspective { get; set; }
        [ForeignKey("ProjectId")]
        [InverseProperty("ProjProjPerspectiveJoins")]
        public virtual ProjProject? Project { get; set; }
    }
}
