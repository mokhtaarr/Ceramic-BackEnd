using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetAllBatch
    {
        public int ItemAtrribBatchId { get; set; }
        public int? ItemCardId { get; set; }
        [StringLength(250)]
        public string? ItemBatchCode { get; set; }
        [StringLength(500)]
        public string? ItemBatchName1 { get; set; }
        [StringLength(500)]
        public string? ItemBatchName2 { get; set; }
        [Column(TypeName = "decimal(23, 7)")]
        public decimal? MultiplyValues { get; set; }
        public bool UseBatchPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(23, 7)")]
        public decimal? BatchLength { get; set; }
        [Column(TypeName = "numeric(23, 7)")]
        public decimal? BatchWidth { get; set; }
        [Column(TypeName = "numeric(23, 7)")]
        public decimal? BatchHieght { get; set; }
        public bool IsStandard { get; set; }
        public bool IsOpened { get; set; }
        public bool IsScrap { get; set; }
        [StringLength(50)]
        public string? ItemCode { get; set; }
        [StringLength(100)]
        public string? ItemDescA { get; set; }
        public bool? IsAttributeItem { get; set; }
        public bool? IsDimension { get; set; }
        public bool? AllPatchesSamePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FirstPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverage { get; set; }
    }
}
