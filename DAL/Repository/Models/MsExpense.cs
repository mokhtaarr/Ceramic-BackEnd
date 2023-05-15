using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_Expenses")]
    public partial class MsExpense
    {
        [Key]
        public int ExpensesId { get; set; }
        [StringLength(50)]
        public string ExpensesCode { get; set; } = null!;
        [StringLength(100)]
        public string? ExpensesDescA { get; set; }
        [StringLength(100)]
        public string? ExpensesDescE { get; set; }
        /// <summary>
        /// 0 Sales , 1 Purchase , 2 Others
        /// </summary>
        public byte? ExpensesType { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpensesValue { get; set; }
        public int? AccountId { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
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
    }
}
