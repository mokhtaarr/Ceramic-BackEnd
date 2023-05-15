using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_SalesInvoiceExpenses")]
    public partial class MsSalesInvoiceExpense
    {
        [Key]
        public int SalesInvExpenseId { get; set; }
        public int? InvId { get; set; }
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
        public int? CreditAccountId { get; set; }

        [ForeignKey("InvId")]
        [InverseProperty("MsSalesInvoiceExpenses")]
        public virtual MsSalesInvoice? Inv { get; set; }
    }
}
