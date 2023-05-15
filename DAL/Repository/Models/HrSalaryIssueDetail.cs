using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_SalaryIssueDetails")]
    public partial class HrSalaryIssueDetail
    {
        [Key]
        public int SalaryIssuDetailId { get; set; }
        public int? SalaryIssuDocId { get; set; }
        public int? SalaryTypId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ElementCount { get; set; }
        [StringLength(100)]
        public string? ElementCountDesc { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ElementUnitValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AddValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DeductValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OtherValue { get; set; }
        public int? DebitAccountId { get; set; }
        public int? CreditAccountId { get; set; }
        public int? DebitCostcenterId { get; set; }
        public int? CreditCostCenterId { get; set; }
        public int? DebitEmpAccountId { get; set; }
        public int? CreditEmpAccountId { get; set; }

        [ForeignKey("SalaryIssuDocId")]
        [InverseProperty("HrSalaryIssueDetails")]
        public virtual HrSalaryIssueDoc? SalaryIssuDoc { get; set; }
    }
}
