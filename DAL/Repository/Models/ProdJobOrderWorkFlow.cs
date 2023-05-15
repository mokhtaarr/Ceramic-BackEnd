using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_JobOrderWorkFlow")]
    public partial class ProdJobOrderWorkFlow
    {
        [Key]
        public int JobOrderDepartId { get; set; }
        public int? JobOrderId { get; set; }
        public int? DepartMentId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ToDate { get; set; }
        public int? UserId { get; set; }
        [StringLength(500)]
        public string? Note { get; set; }

        [ForeignKey("JobOrderId")]
        [InverseProperty("ProdJobOrderWorkFlows")]
        public virtual ProdJobOrder? JobOrder { get; set; }
    }
}
