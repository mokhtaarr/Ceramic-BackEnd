using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Quality_ItemRecPackages")]
    public partial class QualityItemRecPackage
    {
        [Key]
        public int ItemRecPackId { get; set; }
        public int? ItemRecQualityId { get; set; }
        public int? WorkOrderId { get; set; }
        [StringLength(200)]
        public string? Code { get; set; }
        public int? PackageSerial { get; set; }
        public long? AlterSerial { get; set; }

        [ForeignKey("ItemRecQualityId")]
        [InverseProperty("QualityItemRecPackages")]
        public virtual QualityItemRecCheck? ItemRecQuality { get; set; }
        [ForeignKey("WorkOrderId")]
        [InverseProperty("QualityItemRecPackages")]
        public virtual ProdWorkOrder? WorkOrder { get; set; }
    }
}
