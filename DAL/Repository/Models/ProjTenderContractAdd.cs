using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TenderContractAdds")]
    public partial class ProjTenderContractAdd
    {
        [Key]
        public int TenderContractAddId { get; set; }
        public int? TenderContractId { get; set; }
        public int? AccountId { get; set; }
        [StringLength(50)]
        public string? HelpAccType { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PercentNum { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AddValu { get; set; }
        public bool? AddToExtract { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AddPercent { get; set; }
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
        [InverseProperty("ProjTenderContractAdds")]
        public virtual ProjTenderContract? TenderContract { get; set; }
    }
}
