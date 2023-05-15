using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_Drivers")]
    public partial class SrDriver
    {
        public SrDriver()
        {
            SrVehicleJobOrderDetails = new HashSet<SrVehicleJobOrderDetail>();
        }

        [Key]
        public int DriverId { get; set; }
        public int? TrafficLineId { get; set; }
        [StringLength(50)]
        public string? DriverCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public int? EmpId { get; set; }
        [Column("ID")]
        [StringLength(30)]
        public string? Id { get; set; }
        [StringLength(100)]
        public string? PassPort { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DateOfBirth { get; set; }
        [StringLength(30)]
        public string? DriverLicense { get; set; }
        [StringLength(30)]
        public string? LicenseDescription { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LicenseIssueDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LicenseRenewalDate { get; set; }
        [StringLength(255)]
        public string? LicenseLegalPlace { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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

        [InverseProperty("Driver")]
        public virtual ICollection<SrVehicleJobOrderDetail> SrVehicleJobOrderDetails { get; set; }
    }
}
