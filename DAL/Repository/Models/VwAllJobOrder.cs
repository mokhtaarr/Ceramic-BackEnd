using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwAllJobOrder
    {
        public int JobOrderId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public byte? OrderSource { get; set; }
        public int? DepartMentId { get; set; }
        public byte? OrderType { get; set; }
        public byte? Priority { get; set; }
        public byte? OrderStatus { get; set; }
        public bool? Installation { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
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
        public decimal? CustomerCharged { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetExpenses { get; set; }
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
        public int? CustomerId { get; set; }
        public int? ClientId { get; set; }
        [StringLength(50)]
        public string CustomerCode { get; set; } = null!;
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(100)]
        public string? CustomerDescE { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(20)]
        public string? Fax { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        [StringLength(200)]
        public string? Address1 { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        public int? BookId { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
    }
}
