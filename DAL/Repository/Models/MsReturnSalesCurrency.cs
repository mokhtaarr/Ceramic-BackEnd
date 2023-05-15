using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_ReturnSalesCurrencies")]
    public partial class MsReturnSalesCurrency
    {
        [Key]
        public int RetSaleCurId { get; set; }
        public int? RetSaleId { get; set; }
        public int? CurrencyCategoryId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Count { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Total { get; set; }

        [ForeignKey("RetSaleId")]
        [InverseProperty("MsReturnSalesCurrencies")]
        public virtual MsReturnSale? RetSale { get; set; }
    }
}
