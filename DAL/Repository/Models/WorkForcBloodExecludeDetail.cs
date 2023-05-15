using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("WorkForc_BloodExecludeDetails")]
    public partial class WorkForcBloodExecludeDetail
    {
        [Key]
        public int ExecludPassId { get; set; }
        public int? BloodExecludId { get; set; }
        [Column("WFPassPortId")]
        public int? WfpassPortId { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        public bool? Succeeded { get; set; }

        [ForeignKey("BloodExecludId")]
        [InverseProperty("WorkForcBloodExecludeDetails")]
        public virtual WorkForcBloodExeclude? BloodExeclud { get; set; }
    }
}
