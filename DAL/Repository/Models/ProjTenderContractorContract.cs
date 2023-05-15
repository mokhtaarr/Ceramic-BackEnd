using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TenderContractorContract")]
    public partial class ProjTenderContractorContract
    {
        public ProjTenderContractorContract()
        {
            ProjTenderContractorContractAdds = new HashSet<ProjTenderContractorContractAdd>();
            ProjTenderContractorContractDetails = new HashSet<ProjTenderContractorContractDetail>();
            ProjTenderContractorContractDiscounts = new HashSet<ProjTenderContractorContractDiscount>();
        }

        [Key]
        public int ContractorContractId { get; set; }
        public int? TenderContractId { get; set; }
        public int? TenderId { get; set; }
        public int? TenderQoutationId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? CurrencyId { get; set; }
        public int? ContractTypeId { get; set; }
        public int? AccountId { get; set; }
        [StringLength(50)]
        public string? HelpAccType { get; set; }
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
        public decimal? DownPayment { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DownPaymentPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalValue { get; set; }
        public int? ReviewReasonId { get; set; }
        public byte? ContractSituation { get; set; }
        public byte? ContractStatus { get; set; }
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

        [InverseProperty("ContractorContract")]
        public virtual ICollection<ProjTenderContractorContractAdd> ProjTenderContractorContractAdds { get; set; }
        [InverseProperty("ContractorContract")]
        public virtual ICollection<ProjTenderContractorContractDetail> ProjTenderContractorContractDetails { get; set; }
        [InverseProperty("ContractorContract")]
        public virtual ICollection<ProjTenderContractorContractDiscount> ProjTenderContractorContractDiscounts { get; set; }
    }
}
