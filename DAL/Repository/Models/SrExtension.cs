using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_Extension")]
    public partial class SrExtension
    {
        [Key]
        public int ExtensionId { get; set; }
        public int? TripId { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        public int? HotelId { get; set; }
        /// <summary>
        /// single, double, Trible
        /// </summary>
        public byte? Number { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }

        [ForeignKey("CityId")]
        [InverseProperty("SrExtensions")]
        public virtual MsgaCity? City { get; set; }
        [ForeignKey("HotelId")]
        [InverseProperty("SrExtensions")]
        public virtual SrHotel? Hotel { get; set; }
        [ForeignKey("TripId")]
        [InverseProperty("SrExtensions")]
        public virtual SrTrip? Trip { get; set; }
    }
}
