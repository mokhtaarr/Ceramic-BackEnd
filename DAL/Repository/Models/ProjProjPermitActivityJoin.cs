using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjPermitActivityJoin")]
    public partial class ProjProjPermitActivityJoin
    {
        [Key]
        public int ProjPermitActivityJoinId { get; set; }
        public int? ProjectId { get; set; }
        public int? BuildPermitActivityId { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("BuildPermitActivityId")]
        [InverseProperty("ProjProjPermitActivityJoins")]
        public virtual CodBuildPermitActiv? BuildPermitActivity { get; set; }
        [ForeignKey("ProjectId")]
        [InverseProperty("ProjProjPermitActivityJoins")]
        public virtual ProjProject? Project { get; set; }
    }
}
