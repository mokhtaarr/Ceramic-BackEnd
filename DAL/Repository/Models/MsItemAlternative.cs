using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_ItemAlternatives")]
    public partial class MsItemAlternative
    {
        [Key]
        public int AlterId { get; set; }
        public int? ItemCardId { get; set; }
        public int? AlterItemCardId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }

        [ForeignKey("ItemCardId")]
        [InverseProperty("MsItemAlternatives")]
        public virtual MsItemCard? ItemCard { get; set; }
    }
}
