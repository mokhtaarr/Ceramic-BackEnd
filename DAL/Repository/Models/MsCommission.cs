using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_Commission")]
    public partial class MsCommission
    {
        [Key]
        public int CommissionDocId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? EmpId { get; set; }
        public byte? CalcMethod { get; set; }
        [Column(TypeName = "numeric(10, 4)")]
        public decimal? CommissionPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CommissionValue { get; set; }
        public int? FromBookId { get; set; }
        public int? ToBookId { get; set; }
        public bool? IsPaid { get; set; }
        public int? PaidDocId { get; set; }
    }
}
