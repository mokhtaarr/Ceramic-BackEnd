using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_VehicleRentPurchJoin")]
    public partial class SrVehicleRentPurchJoin
    {
        [Key]
        public int RentPurchJoinId { get; set; }
        [Column("VRentContractId")]
        public int? VrentContractId { get; set; }
        public int? PurInvId { get; set; }
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

        [ForeignKey("PurInvId")]
        [InverseProperty("SrVehicleRentPurchJoins")]
        public virtual MsPurchasInvoice? PurInv { get; set; }
        [ForeignKey("VrentContractId")]
        [InverseProperty("SrVehicleRentPurchJoins")]
        public virtual SrVehicleRenalContract? VrentContract { get; set; }
    }
}
