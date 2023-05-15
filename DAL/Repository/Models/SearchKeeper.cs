using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchKeeper
    {
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(100)]
        public string? KeeperNo { get; set; }
        public bool? IsCollected { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CollectDate { get; set; }
        public bool? IsReturned { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnDate { get; set; }
        [StringLength(151)]
        public string? RecTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RecTrDate { get; set; }
        [StringLength(50)]
        public string? CheckNumber { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidPrice { get; set; }
        [StringLength(100)]
        public string? ClientAccNo { get; set; }
        [StringLength(100)]
        public string? BankDesc { get; set; }
        public bool? IsKembiala { get; set; }
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
        public byte? CheckType { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        public int KeeperId { get; set; }
        public int? BookId { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        [Column("cc2")]
        [StringLength(10)]
        [Unicode(false)]
        public string Cc2 { get; set; } = null!;
        public int? StoreId { get; set; }
    }
}
