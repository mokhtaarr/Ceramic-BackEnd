using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_VehicleJobOrder")]
    public partial class SrVehicleJobOrder
    {
        public SrVehicleJobOrder()
        {
            MsPurchInvVehicleJobOrderJoins = new HashSet<MsPurchInvVehicleJobOrderJoin>();
            MsSalesInvVehiclJobOrderJoins = new HashSet<MsSalesInvVehiclJobOrderJoin>();
            SrVehicleJobOrderDetails = new HashSet<SrVehicleJobOrderDetail>();
        }

        [Key]
        [Column("VJOrderId")]
        public int VjorderId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column("VOrderTypeId")]
        public int? VorderTypeId { get; set; }
        public int? GarageId { get; set; }
        public int? EmpId { get; set; }
        /// <summary>
        /// ItemCardId
        /// </summary>
        public int? VehicleId { get; set; }
        public int? DriverId { get; set; }
        public int? CustomerId { get; set; }
        public int? VendorId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? AccountId { get; set; }
        public int? AddAccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? ContainerTypeId { get; set; }
        public int? CurrencyId { get; set; }
        public int? ItemCardId { get; set; }
        [StringLength(100)]
        public string? ItemNewName { get; set; }
        [StringLength(100)]
        public string? ContainerNo { get; set; }
        [StringLength(200)]
        public string? Name1 { get; set; }
        [StringLength(200)]
        public string? Name2 { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId21 { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public long? StartCounter { get; set; }
        public long? EndCounter { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeToLeav { get; set; }
        /// <summary>
        /// True Closed ;  False  Not Closed
        /// </summary>
        public bool? IsClosed { get; set; }
        [StringLength(100)]
        public string? Supervisor { get; set; }
        public int? ContainersCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCost { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        public bool? ShipExecuted { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(20)]
        public string? Fax { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Email2 { get; set; }
        [StringLength(50)]
        public string? Email3 { get; set; }
        [StringLength(50)]
        public string? Email4 { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        [StringLength(200)]
        public string? Address1 { get; set; }
        [StringLength(200)]
        public string? Address2 { get; set; }
        [StringLength(200)]
        public string? Address3 { get; set; }
        [StringLength(20)]
        public string? Tel2 { get; set; }
        [StringLength(20)]
        public string? Tel3 { get; set; }
        [StringLength(20)]
        public string? Tel4 { get; set; }
        [StringLength(20)]
        public string? Tel5 { get; set; }
        [StringLength(255)]
        public string? AddField1 { get; set; }
        [StringLength(255)]
        public string? AddField2 { get; set; }
        [StringLength(255)]
        public string? AddField3 { get; set; }
        [StringLength(255)]
        public string? AddField4 { get; set; }
        [StringLength(255)]
        public string? AddField5 { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
        public bool? Closed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PermPrintedAt { get; set; }
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
        public int? ShiftId { get; set; }

        [ForeignKey("VehicleId")]
        [InverseProperty("SrVehicleJobOrders")]
        public virtual SrVehicle? Vehicle { get; set; }
        [ForeignKey("VorderTypeId")]
        [InverseProperty("SrVehicleJobOrders")]
        public virtual SrVheicleJobOrderType? VorderType { get; set; }
        [InverseProperty("Vjorder")]
        public virtual ICollection<MsPurchInvVehicleJobOrderJoin> MsPurchInvVehicleJobOrderJoins { get; set; }
        [InverseProperty("Vjorder")]
        public virtual ICollection<MsSalesInvVehiclJobOrderJoin> MsSalesInvVehiclJobOrderJoins { get; set; }
        [InverseProperty("Vjorder")]
        public virtual ICollection<SrVehicleJobOrderDetail> SrVehicleJobOrderDetails { get; set; }
    }
}
