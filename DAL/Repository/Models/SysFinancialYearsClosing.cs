using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sys_FinancialYearsClosing")]
    public partial class SysFinancialYearsClosing
    {
        [Key]
        public int ClosingId { get; set; }
        public int? ClosingCode { get; set; }
        public int FinancialYearsId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ClosingDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ClosingDateHejri { get; set; }
        public int? CurrentYear { get; set; }
        public int? ClosingAccountId { get; set; }
        [StringLength(150)]
        public string? RemarksA { get; set; }
        [StringLength(150)]
        public string? RemarksE { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        public bool? IsCancel { get; set; }
        public bool? IsTransfer { get; set; }
    }
}
