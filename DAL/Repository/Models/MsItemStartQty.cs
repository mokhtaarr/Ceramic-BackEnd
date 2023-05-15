using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ItemStartQty")]
    public partial class MsItemStartQty
    {
        [Key]
        public int StartQtyId { get; set; }
        public int? ItemCardId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? ItemPatchPartitionId { get; set; }
        public int? ItemPartId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyPartiation { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInNotebook { get; set; }

        [ForeignKey("ItemCardId")]
        [InverseProperty("MsItemStartQties")]
        public virtual MsItemCard? ItemCard { get; set; }
    }
}
