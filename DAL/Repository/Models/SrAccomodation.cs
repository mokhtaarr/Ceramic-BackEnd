using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_Accomodation")]
    public partial class SrAccomodation
    {
        public SrAccomodation()
        {
            SrTripAccomDetails = new HashSet<SrTripAccomDetail>();
        }

        [Key]
        public int AccomodationId { get; set; }
        public int? TripId { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        public int? HotelId { get; set; }
        /// <summary>
        /// 1 RO,2 BB,3 HB,4 FB
        /// </summary>
        public byte? AccomodationType { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }

        [ForeignKey("HotelId")]
        [InverseProperty("SrAccomodations")]
        public virtual SrHotel? Hotel { get; set; }
        [ForeignKey("TripId")]
        [InverseProperty("SrAccomodations")]
        public virtual SrTrip? Trip { get; set; }
        [InverseProperty("Accomodation")]
        public virtual ICollection<SrTripAccomDetail> SrTripAccomDetails { get; set; }
    }
}
