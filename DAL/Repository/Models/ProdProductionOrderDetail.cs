using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_ProductionOrderDetail")]
    public partial class ProdProductionOrderDetail
    {
        [Key]
        public int ProdOrderDetailId { get; set; }
        public int? ProductionOrderId { get; set; }
        public int? RecipeId { get; set; }
        public int? RecipeDetaiId { get; set; }
        public int? BillOfMaterialId { get; set; }
        public int? ProLineId { get; set; }

        [ForeignKey("ProductionOrderId")]
        [InverseProperty("ProdProductionOrderDetails")]
        public virtual ProdProductionOrder? ProductionOrder { get; set; }
    }
}
