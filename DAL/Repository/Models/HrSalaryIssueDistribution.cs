using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_SalaryIssueDistribution")]
    public partial class HrSalaryIssueDistribution
    {
        [Key]
        public int SalaryIssuDistId { get; set; }
        public int? SalaryIssuDocId { get; set; }
        public int? AccountId { get; set; }
        public int? CostCenterId { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? SalaryHours { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? SalaryDays { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? SalaryPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ValueShare { get; set; }

        [ForeignKey("SalaryIssuDocId")]
        [InverseProperty("HrSalaryIssueDistributions")]
        public virtual HrSalaryIssueDoc? SalaryIssuDoc { get; set; }
    }
}
