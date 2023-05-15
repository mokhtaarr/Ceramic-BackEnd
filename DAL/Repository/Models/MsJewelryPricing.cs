using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_JewelryPricing")]
    public partial class MsJewelryPricing
    {
        [Key]
        public int GoldPricingId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? GlobalOuncePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? GlobalKiloPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? GlobalGramPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LocalOuncePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LocalKiloPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LocaGramPrice { get; set; }
        /// <summary>
        /// 18,21,24
        /// </summary>
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Kirat { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? KiratLocalPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? KiratGlobalPrice { get; set; }
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PermPrintedAt { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
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
    }
}
