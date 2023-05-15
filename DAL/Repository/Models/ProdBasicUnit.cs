using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_BasicUnits")]
    public partial class ProdBasicUnit
    {
        public ProdBasicUnit()
        {
            InverseParentUnitNavigation = new HashSet<ProdBasicUnit>();
            MsItemUnits = new HashSet<MsItemUnit>();
        }

        [Key]
        public int BasUnitId { get; set; }
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
        [StringLength(500)]
        public string? Remarks { get; set; }
        [StringLength(500)]
        public string? AutoDesc { get; set; }
        [StringLength(50)]
        public string? EtaxUnitCode { get; set; }
        public bool? IsKarat { get; set; }
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

        [ForeignKey("ParentUnit")]
        [InverseProperty("InverseParentUnitNavigation")]
        public virtual ProdBasicUnit? ParentUnitNavigation { get; set; }
        [InverseProperty("ParentUnitNavigation")]
        public virtual ICollection<ProdBasicUnit> InverseParentUnitNavigation { get; set; }
        [InverseProperty("BasUnit")]
        public virtual ICollection<MsItemUnit> MsItemUnits { get; set; }
    }
}
