using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_PurchInvVehicleJobOrderJoin")]
    public partial class MsPurchInvVehicleJobOrderJoin
    {
        [Key]
        public int PurchVehiclJobOrderId { get; set; }
        public int? PurInvId { get; set; }
        [Column("VJOrderId")]
        public int? VjorderId { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }

        [ForeignKey("PurInvId")]
        [InverseProperty("MsPurchInvVehicleJobOrderJoins")]
        public virtual MsPurchasInvoice? PurInv { get; set; }
        [ForeignKey("VjorderId")]
        [InverseProperty("MsPurchInvVehicleJobOrderJoins")]
        public virtual SrVehicleJobOrder? Vjorder { get; set; }
    }
}
