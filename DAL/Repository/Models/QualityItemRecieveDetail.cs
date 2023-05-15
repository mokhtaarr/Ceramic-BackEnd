using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Quality_ItemRecieveDetails")]
    public partial class QualityItemRecieveDetail
    {
        [Key]
        public int ProdItemRecDetailId { get; set; }
        public int? ProdItemRecId { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        [StringLength(60)]
        public string? BarCode { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExecutedQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExecutedQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MissedQtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MissedQuantity { get; set; }
        [StringLength(100)]
        public string? ItemCardDesc { get; set; }
        [StringLength(100)]
        public string? ItemCardDescE { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }

        [ForeignKey("ProdItemRecId")]
        [InverseProperty("QualityItemRecieveDetails")]
        public virtual QualityItemRecieve? ProdItemRec { get; set; }
    }
}
