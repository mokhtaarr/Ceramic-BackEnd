using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_CashTransactionDetail")]
    public partial class MsCashTransactionDetail
    {
        [Key]
        public int PaidDocId { get; set; }
        public int? RectId { get; set; }
        public int? PayId { get; set; }
        public int? AdjustId { get; set; }
        public int? JurnalId { get; set; }
        [StringLength(100)]
        public string? TableCode { get; set; }
        public int? TableId { get; set; }
        public byte? TermType { get; set; }
        public int? CurrencyId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [StringLength(100)]
        public string? TrNoDesc { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Total { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Paid { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NotPaid { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidByDoc { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidBeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NotPaidBeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidByDocBeforeRate { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }

        [ForeignKey("AdjustId")]
        [InverseProperty("MsCashTransactionDetails")]
        public virtual MsAdjustMent? Adjust { get; set; }
        [ForeignKey("JurnalId")]
        [InverseProperty("MsCashTransactionDetails")]
        public virtual CalJurnalEntry? Jurnal { get; set; }
        [ForeignKey("PayId")]
        [InverseProperty("MsCashTransactionDetails")]
        public virtual MsPaymentNote? Pay { get; set; }
        [ForeignKey("RectId")]
        [InverseProperty("MsCashTransactionDetails")]
        public virtual MsReceiptNote? Rect { get; set; }
    }
}
