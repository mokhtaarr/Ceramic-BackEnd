using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TenderOwnerExitractDiscounts")]
    public partial class ProjTenderOwnerExitractDiscount
    {
        [Key]
        public int OwnerExitractDiscId { get; set; }
        public int? OwnerExitractId { get; set; }
        public int? AccountId { get; set; }
        [StringLength(50)]
        public string? HelpAccType { get; set; }
        public bool? Accomulative { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PreviousValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscValu { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccomulativeValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccomulativePercent { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        [StringLength(200)]
        public string? Remarks4 { get; set; }

        [ForeignKey("OwnerExitractId")]
        [InverseProperty("ProjTenderOwnerExitractDiscounts")]
        public virtual ProjTenderOwnerExitract? OwnerExitract { get; set; }
    }
}
