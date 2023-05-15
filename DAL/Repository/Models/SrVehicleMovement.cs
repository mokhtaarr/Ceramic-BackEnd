using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_VehicleMovement")]
    public partial class SrVehicleMovement
    {
        public SrVehicleMovement()
        {
            SrVehicleMovementDetails = new HashSet<SrVehicleMovementDetail>();
        }

        [Key]
        public int VehiclMovId { get; set; }
        public int? VendorId { get; set; }
        public int? StorId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? CurrencyId { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
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
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        public bool? IsPrinted { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetTime { get; set; }
        public int? TaxesId1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxValue1 { get; set; }
        public int? TaxesId2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxValue2 { get; set; }
        public int? TaxesId3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxValue3 { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? InvDueDate { get; set; }
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
        [StringLength(200)]
        public string? Remarks { get; set; }
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

        [InverseProperty("VehiclMov")]
        public virtual ICollection<SrVehicleMovementDetail> SrVehicleMovementDetails { get; set; }
    }
}
