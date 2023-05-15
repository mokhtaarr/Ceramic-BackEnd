using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_AttendElementTrans")]
    public partial class HrAttendElementTran
    {
        [Key]
        public int ElementTransId { get; set; }
        [StringLength(50)]
        public string? TableCode { get; set; }
        public int? TableId { get; set; }
        public int? AttendElementId { get; set; }
        public int? EmpId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? PeriodTableId { get; set; }
        public int? PeriodTablDetailId { get; set; }
        public bool? IsPlus { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? OriginalDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// 1 number,2 minutes,3 hours,4 days
        /// </summary>
        public byte? TimeUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ElementValue { get; set; }
    }
}
