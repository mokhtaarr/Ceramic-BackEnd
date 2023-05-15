using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_ReturnPurchaseCurrencies")]
    public partial class MsReturnPurchaseCurrency
    {
        [Key]
        public int RetPurchCurId { get; set; }
        public int? RetPurchId { get; set; }
        public int? CurrencyCategoryId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Count { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Total { get; set; }

        [ForeignKey("RetPurchId")]
        [InverseProperty("MsReturnPurchaseCurrencies")]
        public virtual MsReturnPurchase? RetPurch { get; set; }
    }
}
