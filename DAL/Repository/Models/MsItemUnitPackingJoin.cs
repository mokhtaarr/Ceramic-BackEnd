using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ItemUnitPackingJoin")]
    public partial class MsItemUnitPackingJoin
    {
        [Key]
        public int ItemPackSizeId { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        public int? PackSizeId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInPackage { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RecomendedQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MineQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MaxQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MaxWheight { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(100)]
        public string? Remarks3 { get; set; }

        [ForeignKey("PackSizeId")]
        [InverseProperty("MsItemUnitPackingJoins")]
        public virtual CodPackingSize? PackSize { get; set; }
        [ForeignKey("UnitId")]
        [InverseProperty("MsItemUnitPackingJoins")]
        public virtual MsItemUnit? Unit { get; set; }
    }
}
