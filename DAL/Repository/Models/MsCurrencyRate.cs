using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_CurrencyRate")]
    public partial class MsCurrencyRate
    {
        [Key]
        public int EqualCurrencyPriceId { get; set; }
        public int? CurrencyId { get; set; }
        public int? EquivalentCurrencyId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastModify { get; set; }

        [ForeignKey("CurrencyId")]
        [InverseProperty("MsCurrencyRates")]
        public virtual MsCurrency? Currency { get; set; }
    }
}
