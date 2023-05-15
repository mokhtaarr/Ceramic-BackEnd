using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjUnitOccupTypeJoin")]
    public partial class ProjProjUnitOccupTypeJoin
    {
        [Key]
        public int ProjUnitOccupTypeJoinId { get; set; }
        public int? ProjUnitId { get; set; }
        public int? UnitOccuTypeId { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("ProjUnitId")]
        [InverseProperty("ProjProjUnitOccupTypeJoins")]
        public virtual ProjProjUnit? ProjUnit { get; set; }
        [ForeignKey("UnitOccuTypeId")]
        [InverseProperty("ProjProjUnitOccupTypeJoins")]
        public virtual CodUnitOccupancyType? UnitOccuType { get; set; }
    }
}
