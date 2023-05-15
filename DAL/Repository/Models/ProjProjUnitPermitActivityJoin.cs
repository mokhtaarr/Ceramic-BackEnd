using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjUnitPermitActivityJoin")]
    public partial class ProjProjUnitPermitActivityJoin
    {
        [Key]
        public int ProjUnitPermitActivityJoinId { get; set; }
        public int? ProjUnitId { get; set; }
        public int? UnitPermitActivId { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("ProjUnitId")]
        [InverseProperty("ProjProjUnitPermitActivityJoins")]
        public virtual ProjProjUnit? ProjUnit { get; set; }
        [ForeignKey("UnitPermitActivId")]
        [InverseProperty("ProjProjUnitPermitActivityJoins")]
        public virtual CodUnitPermittedActivity? UnitPermitActiv { get; set; }
    }
}
