using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ReturnPurchaseExpenses")]
    public partial class MsReturnPurchaseExpense
    {
        [Key]
        public int RetPurchExpenseId { get; set; }
        public int? RetPurchId { get; set; }
        public int? ExpensesId { get; set; }
        public int? CurrencyId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ValueCurrency { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ValueAfterRate { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(100)]
        public string? Remarks3 { get; set; }
        public int? CreditAccountId { get; set; }

        [ForeignKey("RetPurchId")]
        [InverseProperty("MsReturnPurchaseExpenses")]
        public virtual MsReturnPurchase? RetPurch { get; set; }
    }
}
