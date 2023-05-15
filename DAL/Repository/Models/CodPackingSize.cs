using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cod_PackingSize")]
    public partial class CodPackingSize
    {
        public CodPackingSize()
        {
            MsItemUnitPackingJoins = new HashSet<MsItemUnitPackingJoin>();
        }

        [Key]
        public int PackSizeId { get; set; }
        public int Code { get; set; }
        [StringLength(100)]
        public string? DescA { get; set; }
        [StringLength(100)]
        public string? DescE { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Length { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Width { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Hieght { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LengthMeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LengthCentimeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LengthMillimeters { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WidthMeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WidthCentimeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WidthMillimeters { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? HeightMeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? HeightCentimeter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? HeightMillimeters { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PurchasePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Wheight { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        [StringLength(255)]
        public string? RemarksA { get; set; }
        [StringLength(255)]
        public string? RemarksE { get; set; }

        [InverseProperty("PackSize")]
        public virtual ICollection<MsItemUnitPackingJoin> MsItemUnitPackingJoins { get; set; }
    }
}
