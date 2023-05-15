using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("WorkForc_Problems")]
    public partial class WorkForcProblem
    {
        [Key]
        [Column("WorkForc_ProbId")]
        public int WorkForcProbId { get; set; }
        [Column("WFPassPortId")]
        public int WfpassPortId { get; set; }
        public string Complaint { get; set; } = null!;
        [StringLength(50)]
        public string ComplaintType { get; set; } = null!;
    }
}
