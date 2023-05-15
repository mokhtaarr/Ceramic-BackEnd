using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_EmpElementPeriodBalance")]
    public partial class HrEmpElementPeriodBalance
    {
        [Key]
        public int EmpElementId { get; set; }
        public int? EmpId { get; set; }
        public int? AttendElementId { get; set; }
        public int? PeriodTablDetailId { get; set; }
        public int? PeriodTableId { get; set; }
        /// <summary>
        /// 1 minute,2 hour,3 day, 4 number
        /// </summary>
        public byte? TimeUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ElementValue { get; set; }
    }
}
