using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_ItemAttributesBatchesDetails")]
    public partial class ProdItemAttributesBatchesDetail
    {
        [Key]
        public int ItemAtrributBatchValuesId { get; set; }
        public int ItemAtrribBatchId { get; set; }
        public int? AttribValuId { get; set; }
        public int? AttributId { get; set; }
        [StringLength(250)]
        public string? AttribValueDesc { get; set; }

        [ForeignKey("ItemAtrribBatchId")]
        [InverseProperty("ProdItemAttributesBatchesDetails")]
        public virtual ProdItemAttributesBatche ItemAtrribBatch { get; set; } = null!;
    }
}
