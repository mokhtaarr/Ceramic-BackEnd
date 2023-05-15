using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_JobSparts")]
    public partial class SrJobSpart
    {
        [Key]
        public int JobSpareId { get; set; }
        public int? JorderId { get; set; }
        public int? ItemCardId { get; set; }
        [StringLength(100)]
        public string? ItemCode { get; set; }
        [StringLength(100)]
        public string? ItemDescA { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Qty { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Price { get; set; }
        [Column("SPValue", TypeName = "numeric(18, 2)")]
        public decimal? Spvalue { get; set; }
        [Column("SPDescription")]
        [StringLength(255)]
        public string? Spdescription { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }

        [ForeignKey("JorderId")]
        [InverseProperty("SrJobSparts")]
        public virtual SrJobOrder? Jorder { get; set; }
    }
}
