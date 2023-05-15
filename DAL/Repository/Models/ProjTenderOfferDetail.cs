using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TenderOfferDetail")]
    public partial class ProjTenderOfferDetail
    {
        [Key]
        public int TenderOfferDetailId { get; set; }
        public int? TenderOfferId { get; set; }
        public int? TenderQoutDetailId { get; set; }
        public int? TenderItemId { get; set; }
        public int? ParentTenderItemId { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
        public int? BasUnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrice { get; set; }
        public byte? ItemStatus { get; set; }
        [StringLength(100)]
        public string? ItemStatusDesc { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        [StringLength(200)]
        public string? Remarks4 { get; set; }

        [ForeignKey("TenderOfferId")]
        [InverseProperty("ProjTenderOfferDetails")]
        public virtual ProjTenderOffer? TenderOffer { get; set; }
    }
}
