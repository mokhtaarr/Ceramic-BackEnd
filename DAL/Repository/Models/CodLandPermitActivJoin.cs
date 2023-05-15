using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cod_LandPermitActivJoin")]
    public partial class CodLandPermitActivJoin
    {
        [Key]
        public int LandPermitActivJoinId { get; set; }
        public int? LandId { get; set; }
        public int? LandPermitActivId { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("LandId")]
        [InverseProperty("CodLandPermitActivJoins")]
        public virtual CodLand? Land { get; set; }
        [ForeignKey("LandPermitActivId")]
        [InverseProperty("CodLandPermitActivJoins")]
        public virtual CodLandPermtActiv? LandPermitActiv { get; set; }
    }
}
