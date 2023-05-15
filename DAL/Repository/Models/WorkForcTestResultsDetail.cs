using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("WorkForc_TestResultsDetails")]
    public partial class WorkForcTestResultsDetail
    {
        [Key]
        public int TestResultDetailId { get; set; }
        public int? TestResultId { get; set; }
        [Column("WFtempId")]
        public int? WftempId { get; set; }
        [Column("WFPassPortId")]
        public int? WfpassPortId { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        public bool? Succeeded { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Grad { get; set; }

        [ForeignKey("TestResultId")]
        [InverseProperty("WorkForcTestResultsDetails")]
        public virtual WorkForcTestResult? TestResult { get; set; }
    }
}
