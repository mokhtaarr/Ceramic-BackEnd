using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_SalesInvoiceQualityDeliveryDocs")]
    public partial class MsSalesInvoiceQualityDeliveryDoc
    {
        [Key]
        public int QualitySaleDelId { get; set; }
        public int? ItemDeliverId { get; set; }
        public int? InvId { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("InvId")]
        [InverseProperty("MsSalesInvoiceQualityDeliveryDocs")]
        public virtual MsSalesInvoice? Inv { get; set; }
    }
}
