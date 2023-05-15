using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_PeriodTablePolicy")]
    public partial class HrPeriodTablePolicy
    {
        [Key]
        public int PeriodPolicyId { get; set; }
        public int? PeriodTableId { get; set; }
        public int? AttendElementId { get; set; }
        public byte? AttendUnit { get; set; }
        [Column(TypeName = "numeric(10, 3)")]
        public decimal? Approximate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Minimum { get; set; }

        [ForeignKey("PeriodTableId")]
        [InverseProperty("HrPeriodTablePolicies")]
        public virtual HrPeriodsTable? PeriodTable { get; set; }
    }
}
