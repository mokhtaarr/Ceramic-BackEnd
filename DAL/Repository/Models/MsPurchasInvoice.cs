using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_PurchasInvoice")]
    public partial class MsPurchasInvoice
    {
        public MsPurchasInvoice()
        {
            MsPaymentNotes = new HashSet<MsPaymentNote>();
            MsPurchInvVehicleJobOrderJoins = new HashSet<MsPurchInvVehicleJobOrderJoin>();
            MsPurchasInvoiceCurrencies = new HashSet<MsPurchasInvoiceCurrency>();
            MsPurchasInvoiceMultiAccounts = new HashSet<MsPurchasInvoiceMultiAccount>();
            MsPurchaseInvoiceCostReceiveds = new HashSet<MsPurchaseInvoiceCostReceived>();
            MsPurchaseInvoiceExpenses = new HashSet<MsPurchaseInvoiceExpense>();
            MsPurchaseInvoiceItemCards = new HashSet<MsPurchaseInvoiceItemCard>();
            ProdJobOrderPurchaseInvoices = new HashSet<ProdJobOrderPurchaseInvoice>();
            SrVehicleRentPurchJoins = new HashSet<SrVehicleRentPurchJoin>();
        }

        [Key]
        public int PurInvId { get; set; }
        public int? VendorId { get; set; }
        public int? StorId { get; set; }
        public int? PurOrderId { get; set; }
        public int? PurOrderReqId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? CurrencyId { get; set; }
        public int? VendBranchId { get; set; }
        public int? ExpensesId { get; set; }
        public int? FinancialIntervalsId { get; set; }
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
        public byte? RectSourceType { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? AccountId { get; set; }
        public int? TaxesId1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxValue1 { get; set; }
        public int? TaxesId2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxValue2 { get; set; }
        public int? TaxesId3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxValue3 { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(100)]
        public string? InvDescA { get; set; }
        [StringLength(100)]
        public string? InvDescE { get; set; }
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
        /// <summary>
        /// 0  Cash ; 1  Due 
        /// </summary>
        public byte? InvoiceType { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? InvDueDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemTax1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemTax2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemTax3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalExpensesTaxes1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalExpensesTaxes2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalExpensesTaxes3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalTaxValu { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InvTotal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscAmount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscPercent2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscAmount2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscPercent3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscAmount3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscPercent4 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscAmount4 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterTax { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidPriceVisa { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BankTransfer { get; set; }
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        public bool? IsPrinted { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetPriceBeforCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenValueBeforCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenValueWithCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AdvancExpenseWithCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AdvancExpenseBeforCurr { get; set; }
        public bool? IsDelivered { get; set; }
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
        public bool? IsPaid { get; set; }
        public int? PaidDocId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NotPaid { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsShippingInv { get; set; }
        public int? IsNoCostDeliver { get; set; }
        public bool? DeliverNoCostExecut { get; set; }
        public bool? MultiResourceDeliver { get; set; }
        public bool? EtaxSent { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EtaxSentTime { get; set; }
        [StringLength(100)]
        public string? EtaxRemarks { get; set; }
        [StringLength(200)]
        public string? EtaxReference { get; set; }
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
        public bool? IsReturned { get; set; }
        public int? ShiftId { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public bool? IsRemoteEntity { get; set; }
        public int? RemotId { get; set; }
        public int? MainVendServerId { get; set; }

        [ForeignKey("PurOrderId")]
        [InverseProperty("MsPurchasInvoices")]
        public virtual MsPurchasOrder? PurOrder { get; set; }
        [ForeignKey("TaxesId1")]
        [InverseProperty("MsPurchasInvoices")]
        public virtual MsTaxis? TaxesId1Navigation { get; set; }
        [InverseProperty("PurInv")]
        public virtual ICollection<MsPaymentNote> MsPaymentNotes { get; set; }
        [InverseProperty("PurInv")]
        public virtual ICollection<MsPurchInvVehicleJobOrderJoin> MsPurchInvVehicleJobOrderJoins { get; set; }
        [InverseProperty("PurInv")]
        public virtual ICollection<MsPurchasInvoiceCurrency> MsPurchasInvoiceCurrencies { get; set; }
        [InverseProperty("PurInv")]
        public virtual ICollection<MsPurchasInvoiceMultiAccount> MsPurchasInvoiceMultiAccounts { get; set; }
        [InverseProperty("PurInv")]
        public virtual ICollection<MsPurchaseInvoiceCostReceived> MsPurchaseInvoiceCostReceiveds { get; set; }
        [InverseProperty("PurInv")]
        public virtual ICollection<MsPurchaseInvoiceExpense> MsPurchaseInvoiceExpenses { get; set; }
        [InverseProperty("PurInv")]
        public virtual ICollection<MsPurchaseInvoiceItemCard> MsPurchaseInvoiceItemCards { get; set; }
        [InverseProperty("PurInv")]
        public virtual ICollection<ProdJobOrderPurchaseInvoice> ProdJobOrderPurchaseInvoices { get; set; }
        [InverseProperty("PurInv")]
        public virtual ICollection<SrVehicleRentPurchJoin> SrVehicleRentPurchJoins { get; set; }
    }
}
