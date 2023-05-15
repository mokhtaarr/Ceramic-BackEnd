using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ItemPartition")]
    public partial class MsItemPartition
    {
        [Key]
        public int ItemPartId { get; set; }
        public int? ItemCardId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? LotNumberExpiryId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyPartiation { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInNotebook { get; set; }
        [Column("QtyIUnit2Notebook", TypeName = "numeric(38, 10)")]
        public decimal? QtyIunit2Notebook { get; set; }
        [Column("QtyIUnit2Partiation", TypeName = "numeric(38, 10)")]
        public decimal? QtyIunit2Partiation { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCost { get; set; }
        public int? PurchaseNumber { get; set; }
        [Column("FIFOCost", TypeName = "numeric(38, 10)")]
        public decimal? Fifocost { get; set; }
        [Column("LIFOCost", TypeName = "numeric(38, 10)")]
        public decimal? Lifocost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverage { get; set; }
        [StringLength(100)]
        public string? BatchNumberFifoOrLifo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? VarianceQty { get; set; }
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
        /// <summary>
        /// number of updates on the table
        /// </summary>
        [Column("TVersion")]
        public long? Tversion { get; set; }
        /// <summary>
        /// i for inserted, u for updated
        /// </summary>
        [Column("TType")]
        [StringLength(1)]
        [Unicode(false)]
        public string? Ttype { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey("ItemCardId")]
        [InverseProperty("MsItemPartitions")]
        public virtual MsItemCard? ItemCard { get; set; }
        [ForeignKey("StorePartId")]
        [InverseProperty("MsItemPartitions")]
        public virtual MsPartition? StorePart { get; set; }
    }
}
