using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_VehicleRentSalesInvJoin")]
    public partial class SrVehicleRentSalesInvJoin
    {
        [Key]
        public int RentSaleJoinId { get; set; }
        [Column("VRentContractId")]
        public int? VrentContractId { get; set; }
        public int? InvId { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        public int? EmpId { get; set; }
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

        [ForeignKey("InvId")]
        [InverseProperty("SrVehicleRentSalesInvJoins")]
        public virtual MsSalesInvoice? Inv { get; set; }
        [ForeignKey("VrentContractId")]
        [InverseProperty("SrVehicleRentSalesInvJoins")]
        public virtual SrVehicleRenalContract? VrentContract { get; set; }
    }
}
