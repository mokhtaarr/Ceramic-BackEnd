using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_SalesInvVehiclJobOrderJoin")]
    public partial class MsSalesInvVehiclJobOrderJoin
    {
        [Key]
        public int SalesVehiclJobOrderId { get; set; }
        public int? InvId { get; set; }
        [Column("VJOrderId")]
        public int? VjorderId { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }

        [ForeignKey("InvId")]
        [InverseProperty("MsSalesInvVehiclJobOrderJoins")]
        public virtual MsSalesInvoice? Inv { get; set; }
        [ForeignKey("VjorderId")]
        [InverseProperty("MsSalesInvVehiclJobOrderJoins")]
        public virtual SrVehicleJobOrder? Vjorder { get; set; }
    }
}
