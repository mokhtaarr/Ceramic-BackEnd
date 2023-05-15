using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TenderContractDiscounts")]
    public partial class ProjTenderContractDiscount
    {
        [Key]
        public int TenderContractDiscId { get; set; }
        public int? TenderContractId { get; set; }
        public int? AccountId { get; set; }
        [StringLength(50)]
        public string? HelpAccType { get; set; }
        public bool? Accomulative { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CurrentPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscValu { get; set; }
        public bool? DiscFromExtract { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscPercent { get; set; }
        public bool? AffectContract { get; set; }
        public bool? CanExceedValu { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        [StringLength(200)]
        public string? Remarks4 { get; set; }

        [ForeignKey("TenderContractId")]
        [InverseProperty("ProjTenderContractDiscounts")]
        public virtual ProjTenderContract? TenderContract { get; set; }
    }
}
