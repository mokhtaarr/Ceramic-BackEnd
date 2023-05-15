using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TenderContractorContractDiscounts")]
    public partial class ProjTenderContractorContractDiscount
    {
        [Key]
        public int ContractorContractDiscId { get; set; }
        public int? ContractorContractId { get; set; }
        public int? AccountId { get; set; }
        [StringLength(50)]
        public string? HelpAccType { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PercentNum { get; set; }
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

        [ForeignKey("ContractorContractId")]
        [InverseProperty("ProjTenderContractorContractDiscounts")]
        public virtual ProjTenderContractorContract? ContractorContract { get; set; }
    }
}
