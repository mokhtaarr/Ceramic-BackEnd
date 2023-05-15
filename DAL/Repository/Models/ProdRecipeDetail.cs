using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_RecipeDetail")]
    public partial class ProdRecipeDetail
    {
        [Key]
        public int RecipeDetaiId { get; set; }
        public int? RecipeId { get; set; }
        public int? BillOfMaterialId { get; set; }
        public int? ProLineId { get; set; }

        [ForeignKey("RecipeId")]
        [InverseProperty("ProdRecipeDetails")]
        public virtual ProdRecipe? Recipe { get; set; }
    }
}
