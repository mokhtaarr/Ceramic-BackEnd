using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_JobExtrnalExpens")]
    public partial class SrJobExtrnalExpen
    {
        [Key]
        public int JobExpensId { get; set; }
        public int? JorderId { get; set; }
        public int? ResponsibleEmpId { get; set; }
        [StringLength(50)]
        public string? EmpCode { get; set; }
        [StringLength(100)]
        public string? EmpName1 { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? TotalHours { get; set; }
        [Column("EXPValue", TypeName = "numeric(18, 2)")]
        public decimal? Expvalue { get; set; }
        [Column("EXPDescription")]
        [StringLength(500)]
        public string? Expdescription { get; set; }

        [ForeignKey("JorderId")]
        [InverseProperty("SrJobExtrnalExpens")]
        public virtual SrJobOrder? Jorder { get; set; }
    }
}
