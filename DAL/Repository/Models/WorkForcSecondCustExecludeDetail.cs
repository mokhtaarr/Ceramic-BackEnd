using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("WorkForc_SecondCustExecludeDetail")]
    public partial class WorkForcSecondCustExecludeDetail
    {
        [Key]
        public int ExecludPassId { get; set; }
        public int? ScndExecludId { get; set; }
        [Column("WFPassPortId")]
        public int? WfpassPortId { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }

        [ForeignKey("ScndExecludId")]
        [InverseProperty("WorkForcSecondCustExecludeDetails")]
        public virtual WorkForcSecondCustExeclude? ScndExeclud { get; set; }
    }
}
