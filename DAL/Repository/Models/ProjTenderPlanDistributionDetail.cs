using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TenderPlanDistributionDetails")]
    public partial class ProjTenderPlanDistributionDetail
    {
        [Key]
        public int TenderPlanJoinId { get; set; }
        public int? TenderPlanDistId { get; set; }
        public int? TenderPlanDetailId { get; set; }
        public int? TenderDetailId { get; set; }
        public int? BasUnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EstimateDeliverDate { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        [StringLength(200)]
        public string? Remarks4 { get; set; }

        [ForeignKey("TenderPlanDistId")]
        [InverseProperty("ProjTenderPlanDistributionDetails")]
        public virtual ProjTenderPlanDistribution? TenderPlanDist { get; set; }
    }
}
