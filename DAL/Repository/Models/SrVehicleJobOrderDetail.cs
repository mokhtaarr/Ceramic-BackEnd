using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_VehicleJobOrderDetail")]
    public partial class SrVehicleJobOrderDetail
    {
        [Key]
        [Column("VJOrderDetailId")]
        public int VjorderDetailId { get; set; }
        [Column("VJOrderId")]
        public int? VjorderId { get; set; }
        public int? TrafficLineId { get; set; }
        public int? DriverId { get; set; }
        public int? CustomerId { get; set; }
        public int? HotelId { get; set; }
        public int? TripId { get; set; }
        public int? ContainerTypeId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeStart { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeEnd { get; set; }
        [Column("KM", TypeName = "numeric(38, 10)")]
        public decimal? Km { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Cost { get; set; }
        public int? ContainersCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ContainerWeight { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WaitTime { get; set; }
        public bool? IsDamade { get; set; }
        [StringLength(200)]
        public string? DamadeDesc { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [Column("representative")]
        [StringLength(100)]
        public string? Representative { get; set; }
        public int? PersonsCount { get; set; }
        [StringLength(50)]
        public string? PlaceToStart { get; set; }
        [StringLength(50)]
        public string? PlaceToEnd { get; set; }
        [StringLength(100)]
        public string? CompanyName { get; set; }

        [ForeignKey("DriverId")]
        [InverseProperty("SrVehicleJobOrderDetails")]
        public virtual SrDriver? Driver { get; set; }
        [ForeignKey("VjorderId")]
        [InverseProperty("SrVehicleJobOrderDetails")]
        public virtual SrVehicleJobOrder? Vjorder { get; set; }
    }
}
