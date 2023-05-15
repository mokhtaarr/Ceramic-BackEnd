using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("WorkForc_FirstCustExecludeDetail")]
    public partial class WorkForcFirstCustExecludeDetail
    {
        [Key]
        public int ExecludPassId { get; set; }
        public int? ExecludId { get; set; }
        [Column("WFPassPortId")]
        public int? WfpassPortId { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }

        [ForeignKey("ExecludId")]
        [InverseProperty("WorkForcFirstCustExecludeDetails")]
        public virtual WorkForcFirstCustExeclude? Execlud { get; set; }
    }
}
