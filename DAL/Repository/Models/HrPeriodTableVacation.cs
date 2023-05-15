using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_PeriodTableVacations")]
    public partial class HrPeriodTableVacation
    {
        [Key]
        public int PeriodVacatId { get; set; }
        public int? PeriodTableId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? VacationDate { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }

        [ForeignKey("PeriodTableId")]
        [InverseProperty("HrPeriodTableVacations")]
        public virtual HrPeriodsTable? PeriodTable { get; set; }
    }
}
