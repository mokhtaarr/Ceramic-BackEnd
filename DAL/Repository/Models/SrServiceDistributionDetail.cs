using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_ServiceDistributionDetails")]
    public partial class SrServiceDistributionDetail
    {
        [Key]
        public int SerDistDetailId { get; set; }
        public int? SerDistId { get; set; }
        public int? SerReqId { get; set; }
        public int? JobOrderId { get; set; }
        public int? EmpId { get; set; }
        public int? EmpId1 { get; set; }
        public int? EmpId2 { get; set; }
        public int? EmpId3 { get; set; }
        public int? EmpId4 { get; set; }
        public int? EmpId5 { get; set; }
        public int? EmpId6 { get; set; }
        public int? EmpId7 { get; set; }
        public int? EmpId8 { get; set; }
        public int? EmpId9 { get; set; }
        public int? EmpId10 { get; set; }
        public int? EmpId11 { get; set; }
        public int? EmpId12 { get; set; }
        public int? EmpId13 { get; set; }
        public int? EmpId14 { get; set; }
        public int? EmpId15 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EstimateStartTime { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RealStartTime { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EstimateEndTime { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RealEndTime { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        [StringLength(200)]
        public string? AddField1 { get; set; }
        [StringLength(200)]
        public string? AddField2 { get; set; }
        [StringLength(200)]
        public string? AddField3 { get; set; }
        [StringLength(200)]
        public string? AddField4 { get; set; }
        [StringLength(200)]
        public string? AddField5 { get; set; }
        [StringLength(200)]
        public string? AddField6 { get; set; }
        [StringLength(200)]
        public string? AddField7 { get; set; }
        [StringLength(200)]
        public string? AddField8 { get; set; }
        [StringLength(200)]
        public string? AddField9 { get; set; }
        [StringLength(200)]
        public string? AddField10 { get; set; }

        [ForeignKey("SerDistId")]
        [InverseProperty("SrServiceDistributionDetails")]
        public virtual SrServiceDistribution? SerDist { get; set; }
    }
}
