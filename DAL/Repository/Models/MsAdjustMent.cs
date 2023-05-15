using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_AdjustMents")]
    public partial class MsAdjustMent
    {
        public MsAdjustMent()
        {
            MsCashTransactionDetails = new HashSet<MsCashTransactionDetail>();
        }

        [Key]
        public int AdjustId { get; set; }
        public int? StoreId { get; set; }
        public byte? CurrencyId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? PurInvId { get; set; }
        public int? InvId { get; set; }
        public int? RetPurchId { get; set; }
        public int? RetSaleId { get; set; }
        public int? RectId { get; set; }
        public int? PayId { get; set; }
        public int? DocBookId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        /// <summary>
        /// 1 debit, 2 credit
        /// </summary>
        public bool? AdjType { get; set; }
        /// <summary>
        /// 1 customer, 2 vendor
        /// </summary>
        public bool? AdjSourcType { get; set; }
        /// <summary>
        /// customer or vendor id
        /// </summary>
        public int? AdjSourcTypeId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCheques { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalInvoices { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NotPaidInvoices { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DifferenceInvoices { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ResourceBalance { get; set; }
        public bool? IsPaid { get; set; }
        public int? PaidDocId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NotPaid { get; set; }
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
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
        public int? ShiftId { get; set; }

        [InverseProperty("Adjust")]
        public virtual ICollection<MsCashTransactionDetail> MsCashTransactionDetails { get; set; }
    }
}
