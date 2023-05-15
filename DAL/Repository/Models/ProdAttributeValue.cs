using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_AttributeValue")]
    public partial class ProdAttributeValue
    {
        [Key]
        public int AttribValuId { get; set; }
        public int? AttributId { get; set; }
        [StringLength(100)]
        public string? AttributValuName1 { get; set; }
        [StringLength(100)]
        public string? AttributValuName2 { get; set; }
        [StringLength(200)]
        public string? AttributValue { get; set; }
        public bool? IsActive { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? LengthMeter { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? LengthCentimeter { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? LengthMillimeters { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? WidthMeter { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? WidthCentimeter { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? WidthMillimeters { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? HeightMeter { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? HeightCentimeter { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? HeightMillimeters { get; set; }
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

        [ForeignKey("AttributId")]
        [InverseProperty("ProdAttributeValues")]
        public virtual ProdItemAttribute? Attribut { get; set; }
    }
}
