using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_PurchasInvoiceCurrencies")]
    public partial class MsPurchasInvoiceCurrency
    {
        [Key]
        public int PurInvCurId { get; set; }
        public int? PurInvId { get; set; }
        public int? CurrencyCategoryId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Count { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Total { get; set; }

        [ForeignKey("PurInvId")]
        [InverseProperty("MsPurchasInvoiceCurrencies")]
        public virtual MsPurchasInvoice? PurInv { get; set; }
    }
}
