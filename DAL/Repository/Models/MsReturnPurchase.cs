﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_ReturnPurchase")]
    public partial class MsReturnPurchase
    {
        public MsReturnPurchase()
        {
            MsReceiptNotes = new HashSet<MsReceiptNote>();
            MsReturnPurchaseCurrencies = new HashSet<MsReturnPurchaseCurrency>();
            MsReturnPurchaseExpenses = new HashSet<MsReturnPurchaseExpense>();
            MsReturnPurchaseItems = new HashSet<MsReturnPurchaseItem>();
            MsReturnPurchaseMultiAccounts = new HashSet<MsReturnPurchaseMultiAccount>();
        }

        [Key]
        public int RetPurchId { get; set; }
        public int? PurInvId { get; set; }
        public int? VendorId { get; set; }
        public int? StoreId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? VendBranchId { get; set; }
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
        public string? RetDescA { get; set; }
        [StringLength(100)]
        public string? RetDescE { get; set; }
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
        /// 0 Cash ; 1 Due ;
        /// </summary>
        public byte? InvoiceType { get; set; }
        /// <summary>
        /// 0  Invoice ; 1 customer
        /// </summary>
        public byte? ReturnType { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ReturnQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemTax1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemTax2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemTax3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalTaxValu { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RetTotal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidPriceVisa { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BankTransfer { get; set; }
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
        public decimal? Rate { get; set; }
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
        public bool? Closed { get; set; }
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
        public bool? IsShippingInv { get; set; }
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
        public int? ShiftId { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public bool? IsRemoteEntity { get; set; }
        public int? RemotId { get; set; }
        public int? MainVendServerId { get; set; }

        [InverseProperty("RetPur")]
        public virtual ICollection<MsReceiptNote> MsReceiptNotes { get; set; }
        [InverseProperty("RetPurch")]
        public virtual ICollection<MsReturnPurchaseCurrency> MsReturnPurchaseCurrencies { get; set; }
        [InverseProperty("RetPurch")]
        public virtual ICollection<MsReturnPurchaseExpense> MsReturnPurchaseExpenses { get; set; }
        [InverseProperty("RetPurch")]
        public virtual ICollection<MsReturnPurchaseItem> MsReturnPurchaseItems { get; set; }
        [InverseProperty("RetPurch")]
        public virtual ICollection<MsReturnPurchaseMultiAccount> MsReturnPurchaseMultiAccounts { get; set; }
    }
}