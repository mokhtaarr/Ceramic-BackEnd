using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_RealItems")]
    public partial class ProjRealItem
    {
        [Key]
        public int ProjectRealItemId { get; set; }
        public int? ProjectId { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        [StringLength(100)]
        public string? AttributeCode { get; set; }
        [StringLength(250)]
        public string? AttributeName { get; set; }
        [Column(TypeName = "numeric(25, 2)")]
        public decimal? SuggestPrice { get; set; }
        [Column(TypeName = "numeric(25, 2)")]
        public decimal? RealCost { get; set; }

        [ForeignKey("ProjectId")]
        [InverseProperty("ProjRealItems")]
        public virtual ProjProject? Project { get; set; }
    }
}
