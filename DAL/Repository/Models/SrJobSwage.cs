using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_JobSWages")]
    public partial class SrJobSwage
    {
        [Key]
        [Column("JobSTechId")]
        public int JobStechId { get; set; }
        public int? JorderId { get; set; }
        public int? EmpId { get; set; }
        [StringLength(50)]
        public string? EmpCode { get; set; }
        [StringLength(100)]
        public string? EmpName1 { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? TotalHours { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? HourlyCostRate { get; set; }
        [Column("WValue", TypeName = "numeric(18, 2)")]
        public decimal? Wvalue { get; set; }
        [Column("WDescription")]
        [StringLength(255)]
        public string? Wdescription { get; set; }

        [ForeignKey("JorderId")]
        [InverseProperty("SrJobSwages")]
        public virtual SrJobOrder? Jorder { get; set; }
    }
}
