using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwAllAnalyticalCodTransactionsDetail
    {
        public int? PostQueId { get; set; }
        [Column("AId")]
        public int Aid { get; set; }
        [Column("ParentAId")]
        public int? ParentAid { get; set; }
        public int? CodeLevel { get; set; }
        public byte? CodeLevelType { get; set; }
        [StringLength(50)]
        public string Code { get; set; } = null!;
        [StringLength(100)]
        public string? DescA { get; set; }
        [StringLength(100)]
        public string? DescE { get; set; }
        public bool? Stopped { get; set; }
        public int? AccountId { get; set; }
        public int? CostCenterId { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
        [StringLength(100)]
        public string? AddField3 { get; set; }
        [StringLength(100)]
        public string? AddField4 { get; set; }
        [StringLength(100)]
        public string? AddField5 { get; set; }
        [StringLength(100)]
        public string? AddField6 { get; set; }
        [StringLength(100)]
        public string? AddField7 { get; set; }
        [StringLength(100)]
        public string? AddField8 { get; set; }
        [StringLength(100)]
        public string? AddField9 { get; set; }
        [StringLength(100)]
        public string? AddField10 { get; set; }
        [StringLength(100)]
        public string? RemarksA { get; set; }
        [StringLength(100)]
        public string? RemarksE { get; set; }
        public long? AccountCode { get; set; }
        [StringLength(100)]
        public string? AccountNameA { get; set; }
        [StringLength(100)]
        public string? AccountNameE { get; set; }
        public int? CostCenterCode { get; set; }
        [StringLength(100)]
        public string? CostCenterNameA { get; set; }
        [StringLength(100)]
        public string? CostCenterNameE { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(24)]
        [Unicode(false)]
        public string DocType { get; set; } = null!;
        [StringLength(21)]
        [Unicode(false)]
        public string DocTypeName1 { get; set; } = null!;
        [StringLength(29)]
        [Unicode(false)]
        public string DocTypeName2 { get; set; } = null!;
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? ManualTrNo { get; set; }
        [StringLength(2000)]
        public string? DocRemarks { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenBalancDepCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenBalancCredCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DebitLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenBalancDepCrncyCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenBalancCredCrncyCostCentr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DebitCurrency { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditCurrency { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [StringLength(50)]
        public string? CurrencyCode { get; set; }
        [StringLength(100)]
        public string? CurrencyDescA { get; set; }
        public bool? DefualtCurrency { get; set; }
        [StringLength(50)]
        public string? CurrencySymbol { get; set; }
        [StringLength(100)]
        public string? ItemCode { get; set; }
        [StringLength(200)]
        public string? ItemDescA { get; set; }
        [StringLength(200)]
        public string? ItemDescE { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        public int? CurrencyId { get; set; }
        [StringLength(100)]
        public string? AddField11 { get; set; }
        [StringLength(100)]
        public string? AddField14 { get; set; }
    }
}
