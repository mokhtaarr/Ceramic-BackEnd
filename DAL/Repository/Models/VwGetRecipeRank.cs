using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetRecipeRank
    {
        public long? RowRank { get; set; }
        public int RecipeId { get; set; }
        [StringLength(50)]
        public string? RecipeCode { get; set; }
    }
}
