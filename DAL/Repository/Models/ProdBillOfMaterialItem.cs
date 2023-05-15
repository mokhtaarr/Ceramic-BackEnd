using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_BillOfMaterialItems")]
    public partial class ProdBillOfMaterialItem
    {
        [Key]
        public int BillItemsId { get; set; }
        public int BillOfMaterialId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        [StringLength(60)]
        public string? BarCode { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MaterialProductPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProductQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProductQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ScrapQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ScrapQuantity { get; set; }
        public int? ProductionUnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProductionUnitRate { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(100)]
        public string? Remarks3 { get; set; }

        [ForeignKey("BillOfMaterialId")]
        [InverseProperty("ProdBillOfMaterialItems")]
        public virtual ProdBillOfMaterial BillOfMaterial { get; set; } = null!;
    }
}
