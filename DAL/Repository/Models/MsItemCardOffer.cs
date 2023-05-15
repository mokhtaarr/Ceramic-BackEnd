using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ItemCardOffers")]
    public partial class MsItemCardOffer
    {
        [Key]
        public int OfferItemId { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BasicQuantity { get; set; }
        public int? GiftItemCardId { get; set; }
        public int? GiftUnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? GiftQuantity { get; set; }
        public bool? IsGiftDiscount { get; set; }
        public bool? IsDiscountPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? GiftDiscount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterDisc { get; set; }
        public bool? IsReplace { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ToDate { get; set; }

        [ForeignKey("ItemCardId")]
        [InverseProperty("MsItemCardOffers")]
        public virtual MsItemCard? ItemCard { get; set; }
    }
}
