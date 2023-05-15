using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwProdItemUnit
    {
        public int ItemCardId { get; set; }
        [StringLength(50)]
        public string? ItemCode { get; set; }
        [StringLength(100)]
        public string? ItemDescA { get; set; }
        [StringLength(100)]
        public string? ItemDescE { get; set; }
        public int UnitId { get; set; }
        public bool? IsDefaultSale { get; set; }
        public bool? IsDefaultPurchas { get; set; }
        public int BasUnitId { get; set; }
        [StringLength(50)]
        public string? UnitCode { get; set; }
        [StringLength(100)]
        public string? UnitNam { get; set; }
        [StringLength(100)]
        public string? UnitNameE { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnittRate { get; set; }
        public int? ParentUnit { get; set; }
        [StringLength(10)]
        public string? Symbol { get; set; }
        public int? UnitMainServerId { get; set; }
        public int? ItemMainServerId { get; set; }
    }
}
