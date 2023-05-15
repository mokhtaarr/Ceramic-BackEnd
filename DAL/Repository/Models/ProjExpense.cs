using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_Expenses")]
    public partial class ProjExpense
    {
        [Key]
        public int ProjectExpensId { get; set; }
        public int? ProjectId { get; set; }
        public int? ExpensesId { get; set; }
        [Column(TypeName = "numeric(25, 2)")]
        public decimal? EstimateValue { get; set; }
        [Column(TypeName = "numeric(10, 4)")]
        public decimal? EstimatePercent { get; set; }
        [Column(TypeName = "numeric(25, 2)")]
        public decimal? RealValue { get; set; }
        [Column(TypeName = "numeric(10, 4)")]
        public decimal? RealPercent { get; set; }

        [ForeignKey("ProjectId")]
        [InverseProperty("ProjExpenses")]
        public virtual ProjProject? Project { get; set; }
    }
}
