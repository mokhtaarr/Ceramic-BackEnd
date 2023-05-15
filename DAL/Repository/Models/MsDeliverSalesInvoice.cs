using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_DeliverSalesInvoice")]
    public partial class MsDeliverSalesInvoice
    {
        public MsDeliverSalesInvoice()
        {
            MsDeliverItemCards = new HashSet<MsDeliverItemCard>();
            MsDeliverSalesInvoiceExpenses = new HashSet<MsDeliverSalesInvoiceExpense>();
            MsDeliverSalesInvoiceMultiAccounts = new HashSet<MsDeliverSalesInvoiceMultiAccount>();
        }

        [Key]
        public int DeliverId { get; set; }
        public int? InvId { get; set; }
        public int? CustomerId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? CurrencyId { get; set; }
        public int? RetPurchId { get; set; }
        public int? JobOrderId { get; set; }
        public int? SalesOrderId { get; set; }
        public int? VendorId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
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
        [Column("AId")]
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DeliverQtyOut { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DeliverQty { get; set; }
        /// <summary>
        /// True Closed ;  False  Not Closed
        /// </summary>
        public bool? IsClosed { get; set; }
        [Column("strCustm4")]
        [StringLength(100)]
        public string? StrCustm4 { get; set; }
        [Column("strCustm5")]
        [StringLength(100)]
        public string? StrCustm5 { get; set; }
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
        /// 0 Invoice ; 1 Customer ; 2 Return
        /// </summary>
        public byte? Status { get; set; }
        public bool? IsPrinted { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetPriceFromInv { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCostAverage { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalLastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetPricFromInvBeforCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCostAveragBeforCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalLastCostBeforCurr { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
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
        public bool? CostExecuted { get; set; }
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

        [InverseProperty("Deliver")]
        public virtual ICollection<MsDeliverItemCard> MsDeliverItemCards { get; set; }
        [InverseProperty("Deliver")]
        public virtual ICollection<MsDeliverSalesInvoiceExpense> MsDeliverSalesInvoiceExpenses { get; set; }
        [InverseProperty("Deliver")]
        public virtual ICollection<MsDeliverSalesInvoiceMultiAccount> MsDeliverSalesInvoiceMultiAccounts { get; set; }
    }
}
