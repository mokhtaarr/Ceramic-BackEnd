using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_ItemCostHistory")]
    public partial class MsItemCostHistory
    {
        [Key]
        public int ItemCostId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? LotNumberExpiryId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyPartiation { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInNotebook { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PurchaseOrder { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WithoutCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ItemLimit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ItemMax { get; set; }
        [Column("FIFOCost", TypeName = "numeric(38, 10)")]
        public decimal? Fifocost { get; set; }
        [Column("LIFOCost", TypeName = "numeric(38, 10)")]
        public decimal? Lifocost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverage { get; set; }
        [StringLength(100)]
        public string? BatchNumberFifoOrLifo { get; set; }
        [StringLength(20)]
        public string? LogType { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LogDate { get; set; }
        [StringLength(70)]
        public string? AffectByTableName { get; set; }
        public int? AffectByTableId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DocQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DocCost { get; set; }
    }
}
