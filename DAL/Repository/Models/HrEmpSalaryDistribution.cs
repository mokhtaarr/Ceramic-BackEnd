using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_EmpSalaryDistribution")]
    public partial class HrEmpSalaryDistribution
    {
        [Key]
        public int SalaryDistId { get; set; }
        public int? EmpId { get; set; }
        public int? AccountId { get; set; }
        public int? CostCenterId { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? SalaryPercent { get; set; }
    }
}
