using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_BillOfMaterial")]
    public partial class ProdBillOfMaterial
    {
        public ProdBillOfMaterial()
        {
            ProdBillOfMaterialItems = new HashSet<ProdBillOfMaterialItem>();
            ProdBillOfMaterialSecondaryItems = new HashSet<ProdBillOfMaterialSecondaryItem>();
        }

        [Key]
        public int BillOfMaterialId { get; set; }
        [Column("BOMCode")]
        [StringLength(50)]
        public string? Bomcode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
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
        public decimal? ScrapQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ScrapQuantity { get; set; }
        public bool? IsScrapCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ScrapCostPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OverflowQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OverflowQuantity { get; set; }
        public bool? IsService { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Duration { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [InverseProperty("BillOfMaterial")]
        public virtual ICollection<ProdBillOfMaterialItem> ProdBillOfMaterialItems { get; set; }
        [InverseProperty("BillOfMaterial")]
        public virtual ICollection<ProdBillOfMaterialSecondaryItem> ProdBillOfMaterialSecondaryItems { get; set; }
    }
}
