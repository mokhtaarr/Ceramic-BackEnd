using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_PurchaseInvoiceExpenses")]
    public partial class MsPurchaseInvoiceExpense
    {
        [Key]
        public int PurExpenseId { get; set; }
        public int? PurInvId { get; set; }
        public int? ExpensesId { get; set; }
        public int? CurrencyId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ValueCurrency { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ValueAfterRate { get; set; }
        public int? TaxesId1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxCurrency1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxAfterRate1 { get; set; }
        public bool? IsRefundableTax1 { get; set; }
        public int? TaxesId2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxCurrency2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxAfterRate2 { get; set; }
        public bool? IsRefundableTax2 { get; set; }
        public int? TaxesId3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxCurrency3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxAfterRate3 { get; set; }
        public bool? IsRefundableTax3 { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }
        public int? CreditAccountId { get; set; }
        public bool? IsAdvancedPay { get; set; }
        public int? PayId { get; set; }

        [ForeignKey("PurInvId")]
        [InverseProperty("MsPurchaseInvoiceExpenses")]
        public virtual MsPurchasInvoice? PurInv { get; set; }
    }
}
