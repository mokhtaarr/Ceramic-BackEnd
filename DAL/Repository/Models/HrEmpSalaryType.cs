using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_EmpSalaryTypes")]
    public partial class HrEmpSalaryType
    {
        [Key]
        public int EmpSalaryTypesId { get; set; }
        public int? EmpId { get; set; }
        public int? SalaryTypId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SalaryValu { get; set; }
        public int? DebitAccId { get; set; }
        public int? CreditAccId { get; set; }
        public int? DebitCostCenterId { get; set; }
        public int? CreditCostCenterId { get; set; }
        public int? DebitEmpAccountId { get; set; }
        public int? CreditEmpAccountId { get; set; }

        [ForeignKey("EmpId")]
        [InverseProperty("HrEmpSalaryTypes")]
        public virtual HrEmployee? Emp { get; set; }
        [ForeignKey("SalaryTypId")]
        [InverseProperty("HrEmpSalaryTypes")]
        public virtual HrSalaryType? SalaryTyp { get; set; }
    }
}
