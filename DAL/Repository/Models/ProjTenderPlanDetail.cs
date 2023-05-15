using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TenderPlanDetails")]
    public partial class ProjTenderPlanDetail
    {
        [Key]
        public int TenderPlanDetailId { get; set; }
        public int? TenderPlanId { get; set; }
        public int? TenderItemId { get; set; }
        public int? ParentTenderItemId { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
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

        [ForeignKey("TenderPlanId")]
        [InverseProperty("ProjTenderPlanDetails")]
        public virtual ProjTenderPlan? TenderPlan { get; set; }
    }
}
