using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Print_PricingDetails")]
    public partial class PrintPricingDetail
    {
        [Key]
        public int PrinPriceIdDetailId { get; set; }
        public int? PrinPriceId { get; set; }
        public int? ItemCardId { get; set; }
        public int? GramTypeId { get; set; }
        public int? GofferId { get; set; }
        public int? ProductTypeId { get; set; }
        public byte? PartSerial { get; set; }
        public byte? Layer { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Factor { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? GramFactor { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Length { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Width { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalDimension { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Weight { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Materialgram { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OperationPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? KnifeLength { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? KnifeWidth { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SolfanPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Slofan { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LayerPrice { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        [StringLength(200)]
        public string? Remarks4 { get; set; }

        [ForeignKey("PrinPriceId")]
        [InverseProperty("PrintPricingDetails")]
        public virtual PrintPricing? PrinPrice { get; set; }
    }
}
