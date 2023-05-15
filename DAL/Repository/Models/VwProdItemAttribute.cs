using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwProdItemAttribute
    {
        public int ItemCardId { get; set; }
        [StringLength(50)]
        public string? ItemCode { get; set; }
        [StringLength(100)]
        public string? ItemDescA { get; set; }
        [StringLength(100)]
        public string? ItemDescE { get; set; }
        public int AttributId { get; set; }
        [StringLength(100)]
        public string? AttributName1 { get; set; }
        [StringLength(100)]
        public string? AttributName2 { get; set; }
        public int? BasUnitId { get; set; }
        [StringLength(50)]
        public string? UnitCode { get; set; }
        [StringLength(100)]
        public string? UnitNam { get; set; }
        [StringLength(100)]
        public string? UnitNameE { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnittRate { get; set; }
        [StringLength(10)]
        public string? Symbol { get; set; }
        public int? ParentUnit { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsMandatory { get; set; }
        [StringLength(50)]
        public string? AttributCode { get; set; }
    }
}
