using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_PaymentNote")]
    [Index("TrNo", "BookId", Name = "StopDoubleTrNoPayment", IsUnique = true)]
    public partial class MsPaymentNote
    {
        public MsPaymentNote()
        {
            MsCashTransactionDetails = new HashSet<MsCashTransactionDetail>();
            MsPaymentNoteCurrencies = new HashSet<MsPaymentNoteCurrency>();
            MsPaymentNoteItems = new HashSet<MsPaymentNoteItem>();
            MsPettyPaymentJoins = new HashSet<MsPettyPaymentJoin>();
            SrVehicleRentPayJoins = new HashSet<SrVehicleRentPayJoin>();
        }

        [Key]
        public int PayId { get; set; }
        public int? PurInvId { get; set; }
        public int? RetSaleId { get; set; }
        public int? BoxId { get; set; }
        public int? CurrencyId { get; set; }
        public int? VendorId { get; set; }
        public int? StoreId { get; set; }
        public int? EmpId { get; set; }
        public int? CustodyEmpId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? ChequeOpenId { get; set; }
        public int? ExpensesId { get; set; }
        public int? BankNoticId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? TripId { get; set; }
        [Column("DBTableName")]
        [StringLength(100)]
        public string? DbtableName { get; set; }
        [Column("DBTableId")]
        public int? DbtableId { get; set; }
        [StringLength(100)]
        public string? AccountTableName { get; set; }
        public int? AccountId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        /// <summary>
        /// 0  Cash ; 1  Check
        /// </summary>
        public byte? TranType { get; set; }
        /// <summary>
        ///  1  Customer ; 2 vendor ; 3  Other
        /// </summary>
        public byte? RectSourceType { get; set; }
        [StringLength(100)]
        public string? OtherSource { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ValueBeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value1BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value2BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value3BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value4 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value4BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value5 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value5BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value6 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value6BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value7 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value7BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value8 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value8BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value9 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value9BeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value10 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Value10BeforeRate { get; set; }
        [StringLength(1000)]
        public string? Equation { get; set; }
        [StringLength(50)]
        public string? CheckNumber { get; set; }
        [StringLength(50)]
        public string? BankAccNumber { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PaidDate { get; set; }
        /// <summary>
        /// 0 Paid ; 1 Back ; 2  Transfer;
        /// </summary>
        public byte? CheckType { get; set; }
        [Column("strCustm1")]
        [StringLength(100)]
        public string? StrCustm1 { get; set; }
        [Column("strCustm2")]
        [StringLength(100)]
        public string? StrCustm2 { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? AddField3 { get; set; }
        [StringLength(100)]
        public string? AddField4 { get; set; }
        [StringLength(100)]
        public string? AddField5 { get; set; }
        [StringLength(100)]
        public string? AddField6 { get; set; }
        [StringLength(100)]
        public string? AddField7 { get; set; }
        public bool? IsPrinted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        public bool? IsPettyCash { get; set; }
        public int? CheqBookId { get; set; }
        public int? NoteNum { get; set; }
        public bool? IsKembiala { get; set; }
        public int? RectId { get; set; }
        public bool? Closed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItems { get; set; }
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
        public byte[]? LastUpdateTime { get; set; }
        public bool? IsRemoteEntity { get; set; }
        public int? RemotId { get; set; }
        public int? MainVendServerId { get; set; }

        [ForeignKey("BoxId")]
        [InverseProperty("MsPaymentNotes")]
        public virtual MsBoxBank? Box { get; set; }
        [ForeignKey("PurInvId")]
        [InverseProperty("MsPaymentNotes")]
        public virtual MsPurchasInvoice? PurInv { get; set; }
        [ForeignKey("RetSaleId")]
        [InverseProperty("MsPaymentNotes")]
        public virtual MsReturnSale? RetSale { get; set; }
        [InverseProperty("Pay")]
        public virtual ICollection<MsCashTransactionDetail> MsCashTransactionDetails { get; set; }
        [InverseProperty("Pay")]
        public virtual ICollection<MsPaymentNoteCurrency> MsPaymentNoteCurrencies { get; set; }
        [InverseProperty("Pay")]
        public virtual ICollection<MsPaymentNoteItem> MsPaymentNoteItems { get; set; }
        [InverseProperty("Pay")]
        public virtual ICollection<MsPettyPaymentJoin> MsPettyPaymentJoins { get; set; }
        [InverseProperty("Pay")]
        public virtual ICollection<SrVehicleRentPayJoin> SrVehicleRentPayJoins { get; set; }
    }
}
