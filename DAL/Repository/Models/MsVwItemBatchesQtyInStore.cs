using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class MsVwItemBatchesQtyInStore
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
        public int ItemAtrribBatchId { get; set; }
        [StringLength(250)]
        public string? ItemBatchCode { get; set; }
        [StringLength(500)]
        public string? ItemBatchName1 { get; set; }
    }
}
