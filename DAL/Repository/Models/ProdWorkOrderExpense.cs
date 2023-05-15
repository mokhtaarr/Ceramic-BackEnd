using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_WorkOrderExpenses")]
    public partial class ProdWorkOrderExpense
    {
        [Key]
        public int WorkOrderExpenseId { get; set; }
        public int? WorkOrderId { get; set; }
        public int? AccountId { get; set; }
        [Column(TypeName = "decimal(25, 3)")]
        public decimal? ExpensValue { get; set; }
        public int? CurrencyId { get; set; }
        public int? EmpId { get; set; }
        public int? BillOfMaterialId { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? TimeBeforFormat { get; set; }
        /// <summary>
        /// 1 Minutes, 2 Hours,3 Days, 4 Months
        /// </summary>
        public byte? TimeUnit { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Minutes { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Hours { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Days { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Months { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [Column("bitOnClient")]
        public bool? BitOnClient { get; set; }

        [ForeignKey("WorkOrderId")]
        [InverseProperty("ProdWorkOrderExpenses")]
        public virtual ProdWorkOrder? WorkOrder { get; set; }
    }
}
