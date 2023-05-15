using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_SalesInvoice")]
    [Index("StoreId", Name = "StoreIdIndex")]
    public partial class MsSalesInvoice
    {
        public MsSalesInvoice()
        {
            MsReceiptNotes = new HashSet<MsReceiptNote>();
            MsSalesInvJobOrderJoins = new HashSet<MsSalesInvJobOrderJoin>();
            MsSalesInvVehiclJobOrderJoins = new HashSet<MsSalesInvVehiclJobOrderJoin>();
            MsSalesInvoiceCostDelivers = new HashSet<MsSalesInvoiceCostDeliver>();
            MsSalesInvoiceCurrencies = new HashSet<MsSalesInvoiceCurrency>();
            MsSalesInvoiceExpenses = new HashSet<MsSalesInvoiceExpense>();
            MsSalesInvoiceItemCards = new HashSet<MsSalesInvoiceItemCard>();
            MsSalesInvoiceMultiAccounts = new HashSet<MsSalesInvoiceMultiAccount>();
            MsSalesInvoiceQualityDeliveryDocs = new HashSet<MsSalesInvoiceQualityDeliveryDoc>();
            MsSalesInvoiceQualityMissedItems = new HashSet<MsSalesInvoiceQualityMissedItem>();
            SrVehicleRentSalesInvJoins = new HashSet<SrVehicleRentSalesInvJoin>();
        }

        [Key]
        public int InvId { get; set; }
        public int? CustomerId { get; set; }
        public int? StoreId { get; set; }
        public int? CurrencyId { get; set; }
        public int? ExpensesId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? SalesOfferId { get; set; }
        public int? SalesOrderId { get; set; }
        public int? EmpId { get; set; }
        public int? CustBranchId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? PayMethodId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PayMethodPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PayMethodValue { get; set; }
        [StringLength(250)]
        public string? PayMethodDatafield { get; set; }
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
        public int TrNo { get; set; }
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
        public decimal? InvQuantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemTax1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemTax2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemTax3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalTaxValu { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InvTotal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemsCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemsProfit { get; set; }
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
        public decimal? PaidPriceVisa { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BankTransfer { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalJobOrders { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Commision { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ItemCommision { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetPriceBeforCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenValueBeforCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenValueWithCurr { get; set; }
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? IsDelivered { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalQtyPump { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalQtyCar { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalQtyNoVehicl { get; set; }
        public bool? IsPos { get; set; }
        public bool? IsHold { get; set; }
        public bool? IsShippingInv { get; set; }
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
        public int? MainCustServerId { get; set; }

        [ForeignKey("SalesOfferId")]
        [InverseProperty("MsSalesInvoices")]
        public virtual MsSalesOffer? SalesOffer { get; set; }
        [InverseProperty("Inv")]
        public virtual ICollection<MsReceiptNote> MsReceiptNotes { get; set; }
        [InverseProperty("Inv")]
        public virtual ICollection<MsSalesInvJobOrderJoin> MsSalesInvJobOrderJoins { get; set; }
        [InverseProperty("Inv")]
        public virtual ICollection<MsSalesInvVehiclJobOrderJoin> MsSalesInvVehiclJobOrderJoins { get; set; }
        [InverseProperty("Inv")]
        public virtual ICollection<MsSalesInvoiceCostDeliver> MsSalesInvoiceCostDelivers { get; set; }
        [InverseProperty("Inv")]
        public virtual ICollection<MsSalesInvoiceCurrency> MsSalesInvoiceCurrencies { get; set; }
        [InverseProperty("Inv")]
        public virtual ICollection<MsSalesInvoiceExpense> MsSalesInvoiceExpenses { get; set; }
        [InverseProperty("Inv")]
        public virtual ICollection<MsSalesInvoiceItemCard> MsSalesInvoiceItemCards { get; set; }
        [InverseProperty("Inv")]
        public virtual ICollection<MsSalesInvoiceMultiAccount> MsSalesInvoiceMultiAccounts { get; set; }
        [InverseProperty("Inv")]
        public virtual ICollection<MsSalesInvoiceQualityDeliveryDoc> MsSalesInvoiceQualityDeliveryDocs { get; set; }
        [InverseProperty("Inv")]
        public virtual ICollection<MsSalesInvoiceQualityMissedItem> MsSalesInvoiceQualityMissedItems { get; set; }
        [InverseProperty("Inv")]
        public virtual ICollection<SrVehicleRentSalesInvJoin> SrVehicleRentSalesInvJoins { get; set; }
    }
}
