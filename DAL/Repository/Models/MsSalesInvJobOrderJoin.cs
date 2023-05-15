using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_SalesInvJobOrderJoin")]
    public partial class MsSalesInvJobOrderJoin
    {
        [Key]
        public int SalesInvJobOrderId { get; set; }
        public int? InvId { get; set; }
        public int? JobOrderId { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }

        [ForeignKey("InvId")]
        [InverseProperty("MsSalesInvJobOrderJoins")]
        public virtual MsSalesInvoice? Inv { get; set; }
        [ForeignKey("JobOrderId")]
        [InverseProperty("MsSalesInvJobOrderJoins")]
        public virtual ProdJobOrder? JobOrder { get; set; }
    }
}
