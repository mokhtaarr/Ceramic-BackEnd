using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TenderContractorContractAdds")]
    public partial class ProjTenderContractorContractAdd
    {
        [Key]
        public int ContractorContractAddId { get; set; }
        public int? ContractorContractId { get; set; }
        public int? AccountId { get; set; }
        [StringLength(50)]
        public string? HelpAccType { get; set; }
        public bool? Accomulative { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CurrentValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CurrentPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AddPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AddValu { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalValue { get; set; }
        public bool? AddToExitract { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        [StringLength(200)]
        public string? Remarks4 { get; set; }

        [ForeignKey("ContractorContractId")]
        [InverseProperty("ProjTenderContractorContractAdds")]
        public virtual ProjTenderContractorContract? ContractorContract { get; set; }
    }
}
