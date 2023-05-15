using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_EmpsSalaryTemp")]
    public partial class HrEmpsSalaryTemp
    {
        [Key]
        public int EmpsSalaryTempId { get; set; }
        public int? SalaryTypId { get; set; }
        public int? EmpId { get; set; }
        public int? JobId { get; set; }
        public int? DepartMentId { get; set; }
        [Column("HREmpGroupId")]
        public int? HrempGroupId { get; set; }
        public int? StoreId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SalaryValu { get; set; }
        public int? DebitAccId { get; set; }
        public int? CreditAccId { get; set; }
        public int? DebitCostCenterId { get; set; }
        public int? CreditCostCenterId { get; set; }
        public int? DebitEmpAccountId { get; set; }
        public int? CreditEmpAccountId { get; set; }

        [ForeignKey("SalaryTypId")]
        [InverseProperty("HrEmpsSalaryTemps")]
        public virtual HrSalaryType? SalaryTyp { get; set; }
    }
}
