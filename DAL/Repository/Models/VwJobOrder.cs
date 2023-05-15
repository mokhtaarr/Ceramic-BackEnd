using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwJobOrder
    {
        public int JobOrderId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? CustomerId { get; set; }
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(100)]
        public string? CustomerDescE { get; set; }
        public int? ItemCardId { get; set; }
        [StringLength(50)]
        public string? ItemCode { get; set; }
        [StringLength(100)]
        public string? ItemDescA { get; set; }
        [StringLength(100)]
        public string? ItemDescE { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        [StringLength(250)]
        public string? ItemBatchCode { get; set; }
        [StringLength(500)]
        public string? ItemBatchName1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProducedQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalTasksCose { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalJobsCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalEquipCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalExpensesCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPurchInvCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalServices { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalJpbOrder { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalProductsPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalGoStock { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalScrap { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InstallationPrice { get; set; }
        public bool? IsDeliveredGoStock { get; set; }
        public bool? IsDeliveredProducts { get; set; }
        public bool? IsDeliveredScrap { get; set; }
        public bool? IsDeliveredMaterial { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? BookId { get; set; }
        public int? StoreId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscAmount { get; set; }
        [Column(TypeName = "numeric(38, 6)")]
        public decimal? GrandTotal { get; set; }
        [StringLength(200)]
        public string? Name1 { get; set; }
    }
}
