using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchVehicleJobOrder
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        public long? StartCounter { get; set; }
        public long? EndCounter { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeToLeav { get; set; }
        [StringLength(100)]
        public string? Supervisor { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(20)]
        public string? Tel2 { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        [StringLength(200)]
        public string? Address1 { get; set; }
        [StringLength(200)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [Column("VOrderTypeCode")]
        [StringLength(50)]
        public string? VorderTypeCode { get; set; }
        [StringLength(100)]
        public string? VheicleJobOrderTypeName1 { get; set; }
        [StringLength(100)]
        public string? VehicleCode { get; set; }
        [StringLength(100)]
        public string? VehicleName1 { get; set; }
        [StringLength(100)]
        public string? VehicleName2 { get; set; }
        [StringLength(100)]
        public string? RegNo { get; set; }
        [StringLength(100)]
        public string? BodyNo { get; set; }
        [StringLength(100)]
        public string? GarageCode { get; set; }
        [StringLength(100)]
        public string? GarageName1 { get; set; }
        [StringLength(100)]
        public string? GarageName2 { get; set; }
        [StringLength(50)]
        public string? DriverCode { get; set; }
        [StringLength(100)]
        public string? DriverName1 { get; set; }
        [StringLength(100)]
        public string? DriverName2 { get; set; }
        [StringLength(30)]
        public string? DriverLicense { get; set; }
        [StringLength(30)]
        public string? LicenseDescription { get; set; }
        [StringLength(50)]
        public string? EmpCode { get; set; }
        [StringLength(100)]
        public string? EmpName1 { get; set; }
        [StringLength(100)]
        public string? EmpName2 { get; set; }
        public int? BookId { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        [Column("VJOrderId")]
        public int VjorderId { get; set; }
        public int? ContainersCount { get; set; }
        [StringLength(100)]
        public string? ContainerNo { get; set; }
        [StringLength(200)]
        public string? VehicleJobOrderName1 { get; set; }
        [StringLength(200)]
        public string? VehicleJobOrderName2 { get; set; }
    }
}
