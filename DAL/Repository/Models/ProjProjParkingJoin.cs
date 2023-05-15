using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjParkingJoin")]
    public partial class ProjProjParkingJoin
    {
        [Key]
        public int ProjParkJoinId { get; set; }
        public int? ProjectId { get; set; }
        public int? ParkingId { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("ParkingId")]
        [InverseProperty("ProjProjParkingJoins")]
        public virtual CodParking? Parking { get; set; }
        [ForeignKey("ProjectId")]
        [InverseProperty("ProjProjParkingJoins")]
        public virtual ProjProject? Project { get; set; }
    }
}
