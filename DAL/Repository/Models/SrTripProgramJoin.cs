using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_TripProgramJoin")]
    public partial class SrTripProgramJoin
    {
        [Key]
        public int TripProgramJoinId { get; set; }
        public int? TripId { get; set; }
        public int? ProgramId { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(50)]
        public string? Days { get; set; }
        [Column("MTSCruze")]
        [StringLength(50)]
        public string? Mtscruze { get; set; }
        /// <summary>
        /// single, double, Trible
        /// </summary>
        public byte? Number { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("SrTripProgramJoins")]
        public virtual SrProgram? Program { get; set; }
        [ForeignKey("TripId")]
        [InverseProperty("SrTripProgramJoins")]
        public virtual SrTrip? Trip { get; set; }
    }
}
