using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_Transportation")]
    public partial class SrTransportation
    {
        [Key]
        public int TransPortId { get; set; }
        public int? TripId { get; set; }
        public int? VehicleId { get; set; }
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
        [InverseProperty("SrTransportations")]
        public virtual SrTrip? Trip { get; set; }
    }
}
