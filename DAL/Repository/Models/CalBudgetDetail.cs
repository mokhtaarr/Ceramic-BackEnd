using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_BudgetDetails")]
    public partial class CalBudgetDetail
    {
        [Key]
        public int BudgetDetailId { get; set; }
        public int? BudgetId { get; set; }
        public int? AccountId { get; set; }
        public int? FromFinancialIntervalsId { get; set; }
        public int? ToFinancialIntervalsId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Debit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Credit { get; set; }
        public int? CostCenterId { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }

        [ForeignKey("BudgetId")]
        [InverseProperty("CalBudgetDetails")]
        public virtual CalBudget? Budget { get; set; }
    }
}
