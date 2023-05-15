using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TenderContractorExitract")]
    public partial class ProjTenderContractorExitract
    {
        public ProjTenderContractorExitract()
        {
            ProjTenderContractorExitractAdds = new HashSet<ProjTenderContractorExitractAdd>();
            ProjTenderContractorExitractDetails = new HashSet<ProjTenderContractorExitractDetail>();
            ProjTenderContractorExitractDiscounts = new HashSet<ProjTenderContractorExitractDiscount>();
        }

        [Key]
        public int ContractorExitractId { get; set; }
        public int? ContractorContractId { get; set; }
        public int? TenderId { get; set; }
        public int? TenderQoutationId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? CurrencyId { get; set; }
        public int? ContractorAccountId { get; set; }
        [StringLength(50)]
        public string? ContractorHelpAccType { get; set; }
        public int? OwnerAccountId { get; set; }
        [StringLength(50)]
        public string? OwnerHelpAccType { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EstimateDeliverDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FinalDeliverDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ConsultAgreeDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CustomerAgreeDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalValue { get; set; }
        public int? ReviewReasonId { get; set; }
        public byte? ReviewStatus { get; set; }
        public byte? PlanStatus { get; set; }
        public bool? IsInternal { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PermPrintedAt { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
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
        public int? ShiftId { get; set; }

        [InverseProperty("ContractorExitract")]
        public virtual ICollection<ProjTenderContractorExitractAdd> ProjTenderContractorExitractAdds { get; set; }
        [InverseProperty("ContractorExitract")]
        public virtual ICollection<ProjTenderContractorExitractDetail> ProjTenderContractorExitractDetails { get; set; }
        [InverseProperty("ContractorExitract")]
        public virtual ICollection<ProjTenderContractorExitractDiscount> ProjTenderContractorExitractDiscounts { get; set; }
    }
}
