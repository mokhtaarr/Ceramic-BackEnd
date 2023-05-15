using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_Fund")]
    public partial class ProjFund
    {
        [Key]
        public int ProjectFundId { get; set; }
        public int? ProjectId { get; set; }
        public int? AccountId { get; set; }
        [StringLength(100)]
        public string? FundName1 { get; set; }
        [StringLength(100)]
        public string? FundName2 { get; set; }
        [Column(TypeName = "numeric(10, 4)")]
        public decimal? FundPercent { get; set; }
        [Column(TypeName = "numeric(25, 2)")]
        public decimal? FundValue { get; set; }
        [StringLength(250)]
        public string? Description { get; set; }
        [StringLength(100)]
        public string? Contact { get; set; }

        [ForeignKey("ProjectId")]
        [InverseProperty("ProjFunds")]
        public virtual ProjProject? Project { get; set; }
    }
}
