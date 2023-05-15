using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ItemCollection")]
    public partial class MsItemCollection
    {
        [Key]
        public int ItemCollectId { get; set; }
        public int? ItemCardId { get; set; }
        public int? SubItemId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        public bool? IsNotBasic { get; set; }

        [ForeignKey("ItemCardId")]
        [InverseProperty("MsItemCollections")]
        public virtual MsItemCard? ItemCard { get; set; }
    }
}
