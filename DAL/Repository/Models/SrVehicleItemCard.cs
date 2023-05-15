using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_VehicleItemCard")]
    public partial class SrVehicleItemCard
    {
        [Key]
        public int VehclItemPart { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemCardIdIsVehicl { get; set; }
        [StringLength(250)]
        public string? Description { get; set; }

        [ForeignKey("ItemCardId")]
        [InverseProperty("SrVehicleItemCards")]
        public virtual MsItemCard? ItemCard { get; set; }
    }
}
