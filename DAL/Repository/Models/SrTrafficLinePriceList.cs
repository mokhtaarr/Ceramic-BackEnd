using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_TrafficLinePriceList")]
    public partial class SrTrafficLinePriceList
    {
        [Key]
        public int TrafficLineVeiclId { get; set; }
        public int? TrafficLineId { get; set; }
        public int? VehicleId { get; set; }
        public int? ContainerTypeId { get; set; }
        public int? CustomerId { get; set; }
        public int? VendorId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price4 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price5 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price6 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price7 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price8 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price9 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price10 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Cost { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }

        [ForeignKey("ContainerTypeId")]
        [InverseProperty("SrTrafficLinePriceLists")]
        public virtual SrContainerType? ContainerType { get; set; }
        [ForeignKey("TrafficLineId")]
        [InverseProperty("SrTrafficLinePriceLists")]
        public virtual SrTrafficLine? TrafficLine { get; set; }
        [ForeignKey("VehicleId")]
        [InverseProperty("SrTrafficLinePriceLists")]
        public virtual SrVehicle? Vehicle { get; set; }
    }
}
