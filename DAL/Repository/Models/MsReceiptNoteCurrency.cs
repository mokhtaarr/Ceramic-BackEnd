using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ReceiptNoteCurrencies")]
    public partial class MsReceiptNoteCurrency
    {
        [Key]
        public int RecCurId { get; set; }
        public int? RectId { get; set; }
        public int? CurrencyCategoryId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Count { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Total { get; set; }

        [ForeignKey("RectId")]
        [InverseProperty("MsReceiptNoteCurrencies")]
        public virtual MsReceiptNote? Rect { get; set; }
    }
}
