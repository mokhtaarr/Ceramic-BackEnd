using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchBankNotice
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? RefNo { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? KeeperNo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCheques { get; set; }
        [StringLength(50)]
        public string? CurrencyCode { get; set; }
        [StringLength(100)]
        public string? CurrencyDescA { get; set; }
        [StringLength(100)]
        public string? CurrencyDescE { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? PaderDire { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? TranTypeDesc { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BankExpenses { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? BankNoticDetailId { get; set; }
        public int? RectId { get; set; }
        public int? PayId { get; set; }
        public bool? IsCollected { get; set; }
        public bool? IsReturned { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CollectDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnDate { get; set; }
        public bool? Canceled { get; set; }
        public bool? IsTransferred { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TransferredAte { get; set; }
        [StringLength(151)]
        public string? RecDocTrNo { get; set; }
        public int? KeeperId { get; set; }
        [StringLength(50)]
        public string? CheckNumber { get; set; }
        public bool? IsKembiala { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string DocType { get; set; } = null!;
        [StringLength(151)]
        public string? KeeperDocTrNo { get; set; }
        public int BankNoticId { get; set; }
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(100)]
        public string? CustomerDescE { get; set; }
        [Column("cc")]
        [StringLength(12)]
        [Unicode(false)]
        public string Cc { get; set; } = null!;
        [Column("cc2")]
        [StringLength(10)]
        [Unicode(false)]
        public string Cc2 { get; set; } = null!;
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ValueBeforeRate { get; set; }
        public byte? TranType { get; set; }
    }
}
