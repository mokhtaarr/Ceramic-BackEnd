using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_VehicleRenalContract")]
    public partial class SrVehicleRenalContract
    {
        public SrVehicleRenalContract()
        {
            SrVehicleRentPayJoins = new HashSet<SrVehicleRentPayJoin>();
            SrVehicleRentPurchJoins = new HashSet<SrVehicleRentPurchJoin>();
            SrVehicleRentRecJoins = new HashSet<SrVehicleRentRecJoin>();
            SrVehicleRentSalesInvJoins = new HashSet<SrVehicleRentSalesInvJoin>();
        }

        [Key]
        [Column("VRentContractId")]
        public int VrentContractId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        /// <summary>
        /// ItemCardId
        /// </summary>
        public int? VehicleId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? DriverId1 { get; set; }
        public int? DriverId2 { get; set; }
        public int? DriverId3 { get; set; }
        public int? CustomerId { get; set; }
        public int? HotelId { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpectedStartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RealStartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? GetOutDate { get; set; }
        public byte? PaymentMethod { get; set; }
        [StringLength(50)]
        public string? HotelRoom { get; set; }
        public long? StartCounter { get; set; }
        public long? EndCounter { get; set; }
        public long? ConsumedCounter { get; set; }
        public long? AllowanceCounter { get; set; }
        public long? ExtraCounter { get; set; }
        public long? DailyCounter { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? FuelIn { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? FuelOut { get; set; }
        [StringLength(50)]
        public string? VisaNo { get; set; }
        [StringLength(50)]
        public string? Type { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? VisaExpiryDate { get; set; }
        [StringLength(10)]
        public string? VisaCode { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? VisaAmount { get; set; }
        public bool? VisaApproved { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InsuranceValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InsuranceValue2 { get; set; }
        public int? ContractDays { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DayPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InvTotal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DeliveryCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DriverCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FuelCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MaintenanceCost { get; set; }
        [Column("VAT", TypeName = "numeric(38, 10)")]
        public decimal? Vat { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Deposit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetDue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Repaid { get; set; }
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
        public decimal? Commision { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetPriceBeforCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenValueBeforCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenValueWithCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NotPaid { get; set; }
        public bool? IsPaid { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPurchInv { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPayment { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPaidReciept { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalSalesInv { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCostBeforeCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Profit { get; set; }
        public bool? IsClosed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ClosingDate { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(20)]
        public string? Fax { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Email2 { get; set; }
        [StringLength(50)]
        public string? Email3 { get; set; }
        [StringLength(50)]
        public string? Email4 { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        [StringLength(200)]
        public string? Address1 { get; set; }
        [StringLength(200)]
        public string? Address2 { get; set; }
        [StringLength(200)]
        public string? Address3 { get; set; }
        [StringLength(20)]
        public string? Tel2 { get; set; }
        [StringLength(20)]
        public string? Tel3 { get; set; }
        [StringLength(20)]
        public string? Tel4 { get; set; }
        [StringLength(20)]
        public string? Tel5 { get; set; }
        [StringLength(255)]
        public string? AddField1 { get; set; }
        [StringLength(255)]
        public string? AddField2 { get; set; }
        [StringLength(255)]
        public string? AddField3 { get; set; }
        [StringLength(255)]
        public string? AddField4 { get; set; }
        [StringLength(255)]
        public string? AddField5 { get; set; }
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

        [InverseProperty("VrentContract")]
        public virtual ICollection<SrVehicleRentPayJoin> SrVehicleRentPayJoins { get; set; }
        [InverseProperty("VrentContract")]
        public virtual ICollection<SrVehicleRentPurchJoin> SrVehicleRentPurchJoins { get; set; }
        [InverseProperty("VrentContract")]
        public virtual ICollection<SrVehicleRentRecJoin> SrVehicleRentRecJoins { get; set; }
        [InverseProperty("VrentContract")]
        public virtual ICollection<SrVehicleRentSalesInvJoin> SrVehicleRentSalesInvJoins { get; set; }
    }
}
