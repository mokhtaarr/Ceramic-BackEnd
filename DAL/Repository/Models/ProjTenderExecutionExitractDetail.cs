using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TenderExecutionExitractDetail")]
    public partial class ProjTenderExecutionExitractDetail
    {
        [Key]
        public int ExecutExitractDetailId { get; set; }
        public int? ExecutExitractId { get; set; }
        public int? TenderPlanDetailId { get; set; }
        public int? TenderDetailId { get; set; }
        public int? TenderItemId { get; set; }
        public int? ParentTenderItemId { get; set; }
        public int? BasUnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PrevQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TenderCat { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalSubItem { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CurrentQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WorkPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProfitPercent { get; set; }
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

        [ForeignKey("ExecutExitractId")]
        [InverseProperty("ProjTenderExecutionExitractDetails")]
        public virtual ProjTenderExecutionExitract? ExecutExitract { get; set; }
    }
}
