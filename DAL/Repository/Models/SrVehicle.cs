using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_Vehicles")]
    public partial class SrVehicle
    {
        public SrVehicle()
        {
            SrJobOrders = new HashSet<SrJobOrder>();
            SrTrafficLinePriceLists = new HashSet<SrTrafficLinePriceList>();
            SrVehicleJobOrders = new HashSet<SrVehicleJobOrder>();
        }

        /// <summary>
        /// ItemCardId
        /// </summary>
        [Key]
        public int VehicleId { get; set; }
        [StringLength(100)]
        public string? VehicleCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public int? InvItemCardId { get; set; }
        public int? ItemCardId { get; set; }
        public int? InvId { get; set; }
        public int? CustomerId { get; set; }
        public int? VehicleTypId { get; set; }
        public int? VehicleShapeId { get; set; }
        public int? TrafficLineId { get; set; }
        [Column("WId")]
        public int? Wid { get; set; }
        public int? DriverId1 { get; set; }
        public int? DriverId2 { get; set; }
        public int? GarageId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CurrencyId { get; set; }
        public int? VendorId { get; set; }
        /// <summary>
        /// 1 car,2 pump
        /// </summary>
        [Column("VTypeConcrete")]
        public byte? VtypeConcrete { get; set; }
        public bool? IsCompanyCar { get; set; }
        public bool? InWarranty { get; set; }
        public bool? Stopped { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DayCost { get; set; }
        [StringLength(100)]
        public string? RegNo { get; set; }
        [StringLength(100)]
        public string? BodyNo { get; set; }
        [StringLength(100)]
        public string? MotorNo { get; set; }
        public long? StartCounterNo { get; set; }
        public long? CounterNo { get; set; }
        public int? YearModel { get; set; }
        [StringLength(50)]
        public string? Color { get; set; }
        [StringLength(100)]
        public string? OwnerName { get; set; }
        [StringLength(100)]
        public string? OwnerAddress { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PurchaseDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("GarageId")]
        [InverseProperty("SrVehicles")]
        public virtual SrGarage? Garage { get; set; }
        [ForeignKey("VehicleShapeId")]
        [InverseProperty("SrVehicles")]
        public virtual SrVehicleShape? VehicleShape { get; set; }
        [ForeignKey("VehicleTypId")]
        [InverseProperty("SrVehicles")]
        public virtual SrVehicleType? VehicleTyp { get; set; }
        [ForeignKey("Wid")]
        [InverseProperty("SrVehicles")]
        public virtual SrWarranty? WidNavigation { get; set; }
        [InverseProperty("Vehicle")]
        public virtual ICollection<SrJobOrder> SrJobOrders { get; set; }
        [InverseProperty("Vehicle")]
        public virtual ICollection<SrTrafficLinePriceList> SrTrafficLinePriceLists { get; set; }
        [InverseProperty("Vehicle")]
        public virtual ICollection<SrVehicleJobOrder> SrVehicleJobOrders { get; set; }
    }
}
