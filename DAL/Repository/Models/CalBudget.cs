using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_Budget")]
    public partial class CalBudget
    {
        public CalBudget()
        {
            CalBudgetDetails = new HashSet<CalBudgetDetail>();
        }

        [Key]
        public int BudgetId { get; set; }
        public int? StorId { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public int? Aid { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? FromFinancialIntervalsId { get; set; }
        public int? ToFinancialIntervalsId { get; set; }
        [StringLength(100)]
        public string? ScinarioDesc { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(1000)]
        public string? Remarks { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }

        [InverseProperty("Budget")]
        public virtual ICollection<CalBudgetDetail> CalBudgetDetails { get; set; }
    }
}
