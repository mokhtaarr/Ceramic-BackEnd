using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_Recipe")]
    public partial class ProdRecipe
    {
        public ProdRecipe()
        {
            ProdRecipeDetails = new HashSet<ProdRecipeDetail>();
        }

        [Key]
        public int RecipeId { get; set; }
        [StringLength(50)]
        public string? RecipeCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(1000)]
        public string? Description { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? UnitId { get; set; }
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

        [InverseProperty("Recipe")]
        public virtual ICollection<ProdRecipeDetail> ProdRecipeDetails { get; set; }
    }
}
