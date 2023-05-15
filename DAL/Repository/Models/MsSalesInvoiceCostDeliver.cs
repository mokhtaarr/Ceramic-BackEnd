using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_SalesInvoiceCostDeliver")]
    public partial class MsSalesInvoiceCostDeliver
    {
        [Key]
        public int SaleNoCostDelId { get; set; }
        public int? InvId { get; set; }
        public int? DeliverId { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }

        [ForeignKey("InvId")]
        [InverseProperty("MsSalesInvoiceCostDelivers")]
        public virtual MsSalesInvoice? Inv { get; set; }
    }
}
