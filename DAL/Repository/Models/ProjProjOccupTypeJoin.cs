using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjOccupTypeJoin")]
    public partial class ProjProjOccupTypeJoin
    {
        [Key]
        public int ProjOccupTypeJoinId { get; set; }
        public int? ProjectId { get; set; }
        public int? BuildOccupTypeId { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("BuildOccupTypeId")]
        [InverseProperty("ProjProjOccupTypeJoins")]
        public virtual CodBuildOccupType? BuildOccupType { get; set; }
        [ForeignKey("ProjectId")]
        [InverseProperty("ProjProjOccupTypeJoins")]
        public virtual ProjProject? Project { get; set; }
    }
}
