using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_SalesItemsOffersDetails")]
    public partial class MsSalesItemsOffersDetail
    {
        [Key]
        public int ItemOfferId { get; set; }
        public int? PromoOfferId { get; set; }
        public int? ItemCategoryId { get; set; }
        public int? ItemCardId { get; set; }
        public int? BaseItemUnitId { get; set; }
        public int? OfferedItemId { get; set; }
        public int? OfferedItemUnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BaseItemUnitRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BaseQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BaseQtyBeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OfferedItemUnitRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OfferedQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OfferedQtyBeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BaseDiscount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscForTotalPrice { get; set; }
        public bool? IsSeasonal { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ToDate { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        public bool? PriceIncludTaxInSales { get; set; }

        [ForeignKey("PromoOfferId")]
        [InverseProperty("MsSalesItemsOffersDetails")]
        public virtual MsSalesItemsOffer? PromoOffer { get; set; }
    }
}
