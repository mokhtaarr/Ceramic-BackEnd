using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TenderQoutationDetails")]
    public partial class ProjTenderQoutationDetail
    {
        [Key]
        public int TenderQoutDetailId { get; set; }
        public int? TenderQoutationId { get; set; }
        public int? TenderItemId { get; set; }
        public int? ParentTenderItemId { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
        public int? BasUnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TenderQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TenderCat { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TenderTotal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AnalyzQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AnalyzCat { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AnalyzTotalUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AnalyzTotalQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AnalyzTotalCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProfitPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProfitValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalProfit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrice { get; set; }
        public byte? ItemStatus { get; set; }
        [StringLength(100)]
        public string? ItemStatusDesc { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        [StringLength(200)]
        public string? Remarks4 { get; set; }

        [ForeignKey("TenderQoutationId")]
        [InverseProperty("ProjTenderQoutationDetails")]
        public virtual ProjTenderQoutation? TenderQoutation { get; set; }
    }
}
