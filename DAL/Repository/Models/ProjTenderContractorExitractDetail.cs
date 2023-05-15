using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TenderContractorExitractDetail")]
    public partial class ProjTenderContractorExitractDetail
    {
        [Key]
        public int ContractorExitractDetailId { get; set; }
        public int? ContractorExitractId { get; set; }
        public int? TenderPlanDetailId { get; set; }
        public int? TenderDetailId { get; set; }
        public int? TenderItemId { get; set; }
        public int? ParentTenderItemId { get; set; }
        public int? BasUnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PrevQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ContractQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CurrentQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RemainQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PreviousRais { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WorkValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CurrentValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RaisValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RaisPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PrevReturn { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RaisBeforPrevReturn { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TenderCat { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProfitValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TenderItemPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalProfit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TenderTotalPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DistQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalSubDist { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPriceDist { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EstimateDeliverDate { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        [StringLength(200)]
        public string? Remarks4 { get; set; }

        [ForeignKey("ContractorExitractId")]
        [InverseProperty("ProjTenderContractorExitractDetails")]
        public virtual ProjTenderContractorExitract? ContractorExitract { get; set; }
    }
}
