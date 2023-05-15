using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("CRM_SalesPlanDetail")]
    public partial class CrmSalesPlanDetail
    {
        [Key]
        public int SalesPlanDetailId { get; set; }
        public int? SalesPlanId { get; set; }
        public int? LeadId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ToDate { get; set; }
        [StringLength(200)]
        public string? Mission { get; set; }

        [ForeignKey("SalesPlanId")]
        [InverseProperty("CrmSalesPlanDetails")]
        public virtual CrmSalesPlan? SalesPlan { get; set; }
    }
}
