using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_WorkOrderItemRecQualityDocs")]
    public partial class ProdWorkOrderItemRecQualityDoc
    {
        [Key]
        public int WorkOrderRecQualityId { get; set; }
        public int? WorkOrderId { get; set; }
        public int? ItemRecQualityId { get; set; }

        [ForeignKey("WorkOrderId")]
        [InverseProperty("ProdWorkOrderItemRecQualityDocs")]
        public virtual ProdWorkOrder? WorkOrder { get; set; }
    }
}
