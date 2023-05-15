using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_VehicleRentRecJoin")]
    public partial class SrVehicleRentRecJoin
    {
        [Key]
        public int RentRecJoinId { get; set; }
        [Column("VRentContractId")]
        public int? VrentContractId { get; set; }
        public int? RectId { get; set; }
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

        [ForeignKey("RectId")]
        [InverseProperty("SrVehicleRentRecJoins")]
        public virtual MsReceiptNote? Rect { get; set; }
        [ForeignKey("VrentContractId")]
        [InverseProperty("SrVehicleRentRecJoins")]
        public virtual SrVehicleRenalContract? VrentContract { get; set; }
    }
}
