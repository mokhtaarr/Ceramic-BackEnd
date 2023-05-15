using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("CRM_SalesPlan")]
    public partial class CrmSalesPlan
    {
        public CrmSalesPlan()
        {
            CrmSalesPlanDetails = new HashSet<CrmSalesPlanDetail>();
        }

        [Key]
        public int SalesPlanId { get; set; }
        public int? StoreId { get; set; }
        public int? TeamMemberId { get; set; }
        [StringLength(100)]
        public string? PlanName1 { get; set; }
        [StringLength(100)]
        public string? PlanName2 { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ToDate { get; set; }
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

        [InverseProperty("SalesPlan")]
        public virtual ICollection<CrmSalesPlanDetail> CrmSalesPlanDetails { get; set; }
    }
}
