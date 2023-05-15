using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Tr_OpenningBalance")]
    public partial class TrOpenningBalance
    {
        public TrOpenningBalance()
        {
            TrOpenningBalanceDetails = new HashSet<TrOpenningBalanceDetail>();
        }

        [Key]
        [Column("Tr_OpenningBalanceId")]
        public int TrOpenningBalanceId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? BranchId { get; set; }
        public int? ExplainId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalDebitor { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCreditor { get; set; }
        [Column(TypeName = "numeric(38, 1)")]
        public decimal? Balance { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [InverseProperty("TrOpenningBalance")]
        public virtual ICollection<TrOpenningBalanceDetail> TrOpenningBalanceDetails { get; set; }
    }
}
