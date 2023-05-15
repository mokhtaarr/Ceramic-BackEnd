using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ReceiptNote")]
    [Index("TrNo", "BookId", Name = "StopDoubleTrNo", IsUnique = true)]
    public partial class MsReceiptNote
    {
        public MsReceiptNote()
        {
            MsCashTransactionDetails = new HashSet<MsCashTransactionDetail>();
            MsReceiptNoteCurrencies = new HashSet<MsReceiptNoteCurrency>();
            SrVehicleRentRecJoins = new HashSet<SrVehicleRentRecJoin>();
        }

        [Key]
        public int RectId { get; set; }
        public int? InvId { get; set; }
        public int? RetPurId { get; set; }
        public int? BoxId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CustomerId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? EmpId { get; set; }
        public int? CollectorId { get; set; }
        public int? KeeperId { get; set; }
        public int? ChequeOpenId { get; set; }
        public int? BankNoticId { get; set; }
        public int? ReservId { get; set; }
        public int? PayId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InstallDates { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? TripId { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [Column("DBTableName")]
        [StringLength(100)]
        public string? DbtableName { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [Column("DBTableId")]
        public int? DbtableId { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [StringLength(100)]
        public string? AccountTableName { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? AccountId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public byte? TranType { get; set; }
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
        public decimal? Commision { get; set; }
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
        public byte? CheckType { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        public bool? IsPrinted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        [StringLength(100)]
        public string? ClientAccNo { get; set; }
        public int? ClientBankId { get; set; }
        [Column("strCustm1")]
        [StringLength(100)]
        public string? StrCustm1 { get; set; }
        [Column("strCustm2")]
        [StringLength(100)]
        public string? StrCustm2 { get; set; }
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
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
        public int? CheqBookId { get; set; }
        public int? NoteNum { get; set; }
        public bool? IsKembiala { get; set; }
        public bool? Closed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnDate { get; set; }
        public bool? ChequOwnerId { get; set; }
        public int? OwnerTranId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ChequeTran { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public bool? IsRemoteEntity { get; set; }
        public int? RemotId { get; set; }
        public int? MainCustServerId { get; set; }

        [ForeignKey("BoxId")]
        [InverseProperty("MsReceiptNotes")]
        public virtual MsBoxBank? Box { get; set; }
        [ForeignKey("InvId")]
        [InverseProperty("MsReceiptNotes")]
        public virtual MsSalesInvoice? Inv { get; set; }
        [ForeignKey("RetPurId")]
        [InverseProperty("MsReceiptNotes")]
        public virtual MsReturnPurchase? RetPur { get; set; }
        [InverseProperty("Rect")]
        public virtual ICollection<MsCashTransactionDetail> MsCashTransactionDetails { get; set; }
        [InverseProperty("Rect")]
        public virtual ICollection<MsReceiptNoteCurrency> MsReceiptNoteCurrencies { get; set; }
        [InverseProperty("Rect")]
        public virtual ICollection<SrVehicleRentRecJoin> SrVehicleRentRecJoins { get; set; }
    }
}
