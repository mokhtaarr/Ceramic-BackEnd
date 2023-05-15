using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_ProductionLine")]
    public partial class ProdProductionLine
    {
        public ProdProductionLine()
        {
            ProdProductionLineDetails = new HashSet<ProdProductionLineDetail>();
        }

        [Key]
        public int ProLineId { get; set; }
        public int? ProdLinCode { get; set; }
        [StringLength(100)]
        public string? ProdLinName1 { get; set; }
        [StringLength(100)]
        public string? ProdLinName2 { get; set; }
        [StringLength(500)]
        public string? ProdLinDesc { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? StandardQty { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [InverseProperty("ProLine")]
        public virtual ICollection<ProdProductionLineDetail> ProdProductionLineDetails { get; set; }
    }
}
