using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_TripAccomDetail")]
    public partial class SrTripAccomDetail
    {
        [Key]
        public int TripAccomDetailId { get; set; }
        public int? AccomodationId { get; set; }
        public int? CustomerId { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(100)]
        public string? PassPortNo { get; set; }
        [StringLength(50)]
        public string? RoomNo { get; set; }
        public int? PersonCount { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }

        [ForeignKey("AccomodationId")]
        [InverseProperty("SrTripAccomDetails")]
        public virtual SrAccomodation? Accomodation { get; set; }
    }
}
