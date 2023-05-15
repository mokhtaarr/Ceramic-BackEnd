using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_VehicleMovementDetails")]
    public partial class SrVehicleMovementDetail
    {
        [Key]
        public int VehiclMovDetailId { get; set; }
        public int? VehiclMovId { get; set; }
        /// <summary>
        /// ItemCardId
        /// </summary>
        public int? VehicleId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeStart { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeEnd { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetTime { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DayCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrice { get; set; }
        [StringLength(200)]
        public string? DriverName { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }

        [ForeignKey("VehiclMovId")]
        [InverseProperty("SrVehicleMovementDetails")]
        public virtual SrVehicleMovement? VehiclMov { get; set; }
    }
}
