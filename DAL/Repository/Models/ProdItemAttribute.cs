using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_ItemAttributes")]
    public partial class ProdItemAttribute
    {
        public ProdItemAttribute()
        {
            ProdAttributeValues = new HashSet<ProdAttributeValue>();
            ProdItemAttributsJoins = new HashSet<ProdItemAttributsJoin>();
        }

        [Key]
        public int AttributId { get; set; }
        [StringLength(50)]
        public string? AttributCode { get; set; }
        [StringLength(100)]
        public string? AttributName1 { get; set; }
        [StringLength(100)]
        public string? AttributName2 { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsMandatory { get; set; }
        /// <summary>
        /// 0 without,1 length,2 width,3 Height
        /// </summary>
        public byte? Dimension { get; set; }
        public bool? IsFixedMenuValues { get; set; }
        public bool? IsOptionalWithAlarm { get; set; }
        public int? BasUnitId { get; set; }
        public byte? DataType { get; set; }
        [Column(TypeName = "decimal(38, 10)")]
        public decimal? MinValu { get; set; }
        [Column(TypeName = "decimal(38, 10)")]
        public decimal? MaxValu { get; set; }
        [Column(TypeName = "decimal(38, 10)")]
        public decimal? IncrementalValu { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }
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

        [InverseProperty("Attribut")]
        public virtual ICollection<ProdAttributeValue> ProdAttributeValues { get; set; }
        [InverseProperty("Attribut")]
        public virtual ICollection<ProdItemAttributsJoin> ProdItemAttributsJoins { get; set; }
    }
}
