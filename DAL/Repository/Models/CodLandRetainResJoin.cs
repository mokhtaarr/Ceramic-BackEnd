using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cod_LandRetainResJoin")]
    public partial class CodLandRetainResJoin
    {
        [Key]
        public int LandRetainResJoinId { get; set; }
        public int? LandId { get; set; }
        public int? LandRetainResId { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("LandId")]
        [InverseProperty("CodLandRetainResJoins")]
        public virtual CodLand? Land { get; set; }
        [ForeignKey("LandRetainResId")]
        [InverseProperty("CodLandRetainResJoins")]
        public virtual CodLandRetainRson? LandRetainRes { get; set; }
    }
}
