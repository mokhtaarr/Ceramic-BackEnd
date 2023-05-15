using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_ActivityDetailElements")]
    public partial class HrActivityDetailElement
    {
        [Key]
        public int ActivityElementId { get; set; }
        public int? EmpActivityDetailId { get; set; }
        public int? EmpActivityId { get; set; }
        public int? PeriodTableId { get; set; }
        public int? PeriodTablDetailId { get; set; }
        public int? EmpId { get; set; }
        public int? AttendElementId { get; set; }
        public int? EmpElementId { get; set; }
        public byte? TimeUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value { get; set; }

        [ForeignKey("EmpActivityDetailId")]
        [InverseProperty("HrActivityDetailElements")]
        public virtual HrEmpActivityDetail? EmpActivityDetail { get; set; }
    }
}
