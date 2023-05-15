using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_TaskEmp")]
    public partial class SrTaskEmp
    {
        [Key]
        public int TskTech { get; set; }
        public int? TaskId { get; set; }
        public int? EmpId { get; set; }
        [StringLength(250)]
        public string? EmpRole { get; set; }

        [ForeignKey("EmpId")]
        [InverseProperty("SrTaskEmps")]
        public virtual HrEmployee? Emp { get; set; }
        [ForeignKey("TaskId")]
        [InverseProperty("SrTaskEmps")]
        public virtual SrTask? Task { get; set; }
    }
}
