using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_Flight")]
    public partial class SrFlight
    {
        [Key]
        public int FlightId { get; set; }
        public int? TripId { get; set; }
        [StringLength(100)]
        public string? FlightCompany { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Departure { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Arrival { get; set; }
        public int? TrafficLineId { get; set; }
        [Column("CityIDFrom")]
        public int? CityIdfrom { get; set; }
        [Column("CityIDTo")]
        public int? CityIdto { get; set; }
        [StringLength(100)]
        public string? PlaceFrom { get; set; }
        [StringLength(100)]
        public string? PlaceTo { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }

        [ForeignKey("TripId")]
        [InverseProperty("SrFlights")]
        public virtual SrTrip? Trip { get; set; }
    }
}
