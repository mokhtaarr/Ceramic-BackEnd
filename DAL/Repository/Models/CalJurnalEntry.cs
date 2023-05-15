using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_JurnalEntry")]
    public partial class CalJurnalEntry
    {
        public CalJurnalEntry()
        {
            CalJurnalDetails = new HashSet<CalJurnalDetail>();
            MsCashTransactionDetails = new HashSet<MsCashTransactionDetail>();
        }

        [Key]
        public int JurnalId { get; set; }
        public int? StorId { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public int? AdjustId { get; set; }
        public int? BoxTranId { get; set; }
        public int? DeliverId { get; set; }
        public int? PurInvId { get; set; }
        public int? RectId { get; set; }
        public int? RetPurchId { get; set; }
        public int? RetSaleId { get; set; }
        public int? InvId { get; set; }
        public int? StockRecId { get; set; }
        public int? TranId { get; set; }
        public int? PayId { get; set; }
        public int? StockAdjustId { get; set; }
        [Column("Tr_OpenningBalanceId")]
        public int? TrOpenningBalanceId { get; set; }
        public int? KeeperId { get; set; }
        public int? BankNoticId { get; set; }
        public int? PettycashId { get; set; }
        public int? PurOrderId { get; set; }
        public int? SalesOfferId { get; set; }
        public int? SalesOrderId { get; set; }
        public int? ReservId { get; set; }
        public int? SalaryIssuDocId { get; set; }
        public int? DeprDocId { get; set; }
        public int? AssetTerminatId { get; set; }
        public int? AssetAddId { get; set; }
        public int? AssetDeductId { get; set; }
        public int? DeliverAssetId { get; set; }
        public int? FixAssetId { get; set; }
        public int? AssetMovId { get; set; }
        public int? ReceiveAssetId { get; set; }
        [Column("JOrderEmpDocId")]
        public int? JorderEmpDocId { get; set; }
        [Column("JOrderEquipDocId")]
        public int? JorderEquipDocId { get; set; }
        [Column("JOrderClosId")]
        public int? JorderClosId { get; set; }
        public int? LetOfGrnteeTranId { get; set; }
        [Column("VJOrderId")]
        public int? VjorderId { get; set; }
        public int? TranReqId { get; set; }
        public int? VehiclMovId { get; set; }
        public int? Aid { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(200)]
        public string? JurnalDesc { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalDebit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCredit { get; set; }
        public bool? IsOpenning { get; set; }
        public bool? IsManual { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
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
        public int? ShiftId { get; set; }

        [ForeignKey("Aid")]
        [InverseProperty("CalJurnalEntries")]
        public virtual SysAnalyticalCode? AidNavigation { get; set; }
        [ForeignKey("StorId")]
        [InverseProperty("CalJurnalEntries")]
        public virtual MsStore? Stor { get; set; }
        [InverseProperty("Jurnal")]
        public virtual ICollection<CalJurnalDetail> CalJurnalDetails { get; set; }
        [InverseProperty("Jurnal")]
        public virtual ICollection<MsCashTransactionDetail> MsCashTransactionDetails { get; set; }
    }
}
