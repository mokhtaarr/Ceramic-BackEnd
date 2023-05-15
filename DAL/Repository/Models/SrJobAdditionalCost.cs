using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_JobAdditionalCost")]
    public partial class SrJobAdditionalCost
    {
        [Key]
        public int AddCostId { get; set; }
        public int? JorderId { get; set; }
        [StringLength(255)]
        public string? AddCostDesc { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? AdCostValue { get; set; }

        [ForeignKey("JorderId")]
        [InverseProperty("SrJobAdditionalCosts")]
        public virtual SrJobOrder? Jorder { get; set; }
    }
}
