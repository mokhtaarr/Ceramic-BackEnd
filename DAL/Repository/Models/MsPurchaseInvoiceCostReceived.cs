using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_PurchaseInvoiceCostReceived")]
    public partial class MsPurchaseInvoiceCostReceived
    {
        [Key]
        public int PurNoCostStockId { get; set; }
        public int? PurInvId { get; set; }
        public int? StockRecId { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }

        [ForeignKey("PurInvId")]
        [InverseProperty("MsPurchaseInvoiceCostReceiveds")]
        public virtual MsPurchasInvoice? PurInv { get; set; }
    }
}
