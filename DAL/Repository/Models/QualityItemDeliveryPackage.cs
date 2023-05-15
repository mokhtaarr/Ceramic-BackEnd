using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Quality_ItemDeliveryPackages")]
    public partial class QualityItemDeliveryPackage
    {
        [Key]
        public int ItemDeliceryPackId { get; set; }
        public int? ItemDeliverId { get; set; }
        [StringLength(200)]
        public string? Code { get; set; }
        public int? PackageSerial { get; set; }
        public long? AlterSerial { get; set; }

        [ForeignKey("ItemDeliverId")]
        [InverseProperty("QualityItemDeliveryPackages")]
        public virtual QualityItemDelivery? ItemDeliver { get; set; }
    }
}
