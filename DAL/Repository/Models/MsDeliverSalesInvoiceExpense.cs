using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_DeliverSalesInvoiceExpenses")]
    public partial class MsDeliverSalesInvoiceExpense
    {
        [Key]
        public int DeliverIdExpenseId { get; set; }
        public int? DeliverId { get; set; }
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

        [ForeignKey("DeliverId")]
        [InverseProperty("MsDeliverSalesInvoiceExpenses")]
        public virtual MsDeliverSalesInvoice? Deliver { get; set; }
    }
}
