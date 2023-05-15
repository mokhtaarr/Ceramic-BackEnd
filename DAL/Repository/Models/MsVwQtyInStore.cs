using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class MsVwQtyInStore
    {
        [StringLength(50)]
        public string StoreCode { get; set; } = null!;
        [StringLength(100)]
        public string? StoreDescA { get; set; }
        [StringLength(100)]
        public string? StoreDescE { get; set; }
        [StringLength(50)]
        public string PartCode { get; set; } = null!;
        [StringLength(100)]
        public string? PartDescA { get; set; }
        public int? ItemCardId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyPartiation { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInNotebook { get; set; }
        public int StoreId { get; set; }
        public int StorePartId { get; set; }
        [Column("FIFOCost", TypeName = "numeric(38, 10)")]
        public decimal? Fifocost { get; set; }
        [Column("LIFOCost", TypeName = "numeric(38, 10)")]
        public decimal? Lifocost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverage { get; set; }
        [StringLength(100)]
        public string? BatchNumberFifoOrLifo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ProdDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpiryDate { get; set; }
        public int? Period { get; set; }
        public byte? PeriodType { get; set; }
        [StringLength(50)]
        public string? LotNumberExpiry { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ReservedQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RequestedQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SaleNotDelivered { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PurNotReceived { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyOutWithoutBalance { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInWithoutCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SalesOrder { get; set; }
    }
}
