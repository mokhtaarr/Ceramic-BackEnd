using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_PaymentNoteCurrencies")]
    public partial class MsPaymentNoteCurrency
    {
        [Key]
        public int PayCurId { get; set; }
        public int? PayId { get; set; }
        public int? CurrencyCategoryId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Count { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Total { get; set; }

        [ForeignKey("PayId")]
        [InverseProperty("MsPaymentNoteCurrencies")]
        public virtual MsPaymentNote? Pay { get; set; }
    }
}
