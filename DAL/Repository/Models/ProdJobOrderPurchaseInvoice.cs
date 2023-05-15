using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_JobOrderPurchaseInvoices")]
    public partial class ProdJobOrderPurchaseInvoice
    {
        [Key]
        public int JobPurchasInvId { get; set; }
        public int? PurInvId { get; set; }
        public int? JobOrderId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetPrice { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }

        [ForeignKey("JobOrderId")]
        [InverseProperty("ProdJobOrderPurchaseInvoices")]
        public virtual ProdJobOrder? JobOrder { get; set; }
        [ForeignKey("PurInvId")]
        [InverseProperty("ProdJobOrderPurchaseInvoices")]
        public virtual MsPurchasInvoice? PurInv { get; set; }
    }
}
