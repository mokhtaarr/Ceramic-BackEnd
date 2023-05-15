using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cod_LandPosJoin")]
    public partial class CodLandPosJoin
    {
        [Key]
        public int LandPosJoinId { get; set; }
        public int? LandId { get; set; }
        public int? LandPosId { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("LandId")]
        [InverseProperty("CodLandPosJoins")]
        public virtual CodLand? Land { get; set; }
        [ForeignKey("LandPosId")]
        [InverseProperty("CodLandPosJoins")]
        public virtual CodLandPosition? LandPos { get; set; }
    }
}
