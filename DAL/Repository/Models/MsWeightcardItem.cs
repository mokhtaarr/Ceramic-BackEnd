using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_WeightcardItems")]
    public partial class MsWeightcardItem
    {
        [Key]
        public int WeightItemId { get; set; }
        public int? ScaleCardId { get; set; }
        public int? ItemCardId { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        [StringLength(60)]
        public string? BarCode { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        [Column("QtyIUnit2", TypeName = "numeric(38, 10)")]
        public decimal? QtyIunit2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ScaleQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ScaleQtyBeforRate { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
        [StringLength(500)]
        public string? Remarks1 { get; set; }
        [StringLength(500)]
        public string? Remarks2 { get; set; }

        [ForeignKey("ScaleCardId")]
        [InverseProperty("MsWeightcardItems")]
        public virtual MsWeightCard? ScaleCard { get; set; }
    }
}
