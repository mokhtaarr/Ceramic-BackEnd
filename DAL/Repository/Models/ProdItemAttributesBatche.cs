using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_ItemAttributesBatche")]
    public partial class ProdItemAttributesBatche
    {
        public ProdItemAttributesBatche()
        {
            ProdItemAttributesBatchesDetails = new HashSet<ProdItemAttributesBatchesDetail>();
            ProdItemBatchPartitions = new HashSet<ProdItemBatchPartition>();
            ProdJobOrderProducts = new HashSet<ProdJobOrderProduct>();
        }

        [Key]
        public int ItemAtrribBatchId { get; set; }
        public int? ItemCardId { get; set; }
        [StringLength(250)]
        public string? ItemBatchCode { get; set; }
        [StringLength(500)]
        public string? ItemBatchName1 { get; set; }
        [StringLength(500)]
        public string? ItemBatchName2 { get; set; }
        [StringLength(500)]
        public string? ItemBatchDesc { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Tax { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MultiplyValues { get; set; }
        public bool? UseBatchPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscountPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscountValue { get; set; }
        public int? ParentBatchId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BatchLength { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BatchWidth { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BatchHieght { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LengthMeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LengthCentimeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LengthMillimeters { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WidthMeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WidthCentimeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WidthMillimeters { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? HeightMeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? HeightCentimeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? HeightMillimeters { get; set; }
        public bool? IsStandard { get; set; }
        public bool? IsOpened { get; set; }
        public bool? IsScrap { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInBox { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? PurchasePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Wheight { get; set; }
        public bool? IsTempItem { get; set; }

        [InverseProperty("ItemAtrribBatch")]
        public virtual ICollection<ProdItemAttributesBatchesDetail> ProdItemAttributesBatchesDetails { get; set; }
        [InverseProperty("ItemAtrribBatch")]
        public virtual ICollection<ProdItemBatchPartition> ProdItemBatchPartitions { get; set; }
        [InverseProperty("ItemAtrribBatch")]
        public virtual ICollection<ProdJobOrderProduct> ProdJobOrderProducts { get; set; }
    }
}
