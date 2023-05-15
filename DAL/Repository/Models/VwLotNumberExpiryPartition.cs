using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwLotNumberExpiryPartition
    {
        public int LotNumberExpiryId { get; set; }
        [StringLength(50)]
        public string? LotNumberExpiry { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ProdDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpiryDate { get; set; }
        public byte? PeriodType { get; set; }
        public bool? Disabled { get; set; }
        public int? ItemCardId { get; set; }
        [StringLength(50)]
        public string? ItemCode { get; set; }
        [StringLength(100)]
        public string? ItemDescA { get; set; }
        [StringLength(100)]
        public string? ItemDescE { get; set; }
        public byte? ItemType { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        [StringLength(50)]
        public string? PartCode { get; set; }
        [StringLength(100)]
        public string? PartDescA { get; set; }
        [StringLength(50)]
        public string? PartDescE { get; set; }
        [StringLength(50)]
        public string? StoreCode { get; set; }
        [StringLength(100)]
        public string? StoreDescA { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyPartiation { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInNotebook { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverage { get; set; }
        [Column("FIFOCost", TypeName = "numeric(38, 10)")]
        public decimal? Fifocost { get; set; }
        [Column("LIFOCost", TypeName = "numeric(38, 10)")]
        public decimal? Lifocost { get; set; }
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
        public decimal? WithoutCost { get; set; }
        [Column("TVersion")]
        public long? Tversion { get; set; }
        [Column("TType")]
        [StringLength(1)]
        [Unicode(false)]
        public string? Ttype { get; set; }
        [Column("MaxTVersion")]
        public long? MaxTversion { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        [StringLength(250)]
        public string? ItemBatchCode { get; set; }
        [StringLength(500)]
        public string? ItemBatchName1 { get; set; }
        [StringLength(100)]
        public string? Remark { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(100)]
        public string? Remarks3 { get; set; }
        [StringLength(100)]
        public string? Remarks4 { get; set; }
        [StringLength(100)]
        public string? Remarks5 { get; set; }
        [StringLength(100)]
        public string? Remarks6 { get; set; }
        [StringLength(100)]
        public string? Remarks7 { get; set; }
    }
}
