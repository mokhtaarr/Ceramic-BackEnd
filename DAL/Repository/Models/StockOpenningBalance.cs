using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Stock_OpenningBalance")]
    public partial class StockOpenningBalance
    {
        public StockOpenningBalance()
        {
            StockOpenningBalanceDetails = new HashSet<StockOpenningBalanceDetail>();
        }

        [Key]
        public int StockOpenId { get; set; }
        public int? StockTranTypId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? StockPortfolioId { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public bool? FollowCash { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [InverseProperty("StockOpen")]
        public virtual ICollection<StockOpenningBalanceDetail> StockOpenningBalanceDetails { get; set; }
    }
}
