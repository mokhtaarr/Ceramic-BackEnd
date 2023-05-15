using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchVehicleRenalContract
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
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
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(100)]
        public string? VehicleCode { get; set; }
        [StringLength(100)]
        public string? VehicleName1 { get; set; }
        [StringLength(100)]
        public string? VehicleName2 { get; set; }
        [StringLength(100)]
        public string? RegNo { get; set; }
        [StringLength(100)]
        public string? BodyNo { get; set; }
        [StringLength(100)]
        public string? MotorNo { get; set; }
        public long? StartCounterNo { get; set; }
        public long? CounterNo { get; set; }
        public int? YearModel { get; set; }
        [StringLength(50)]
        public string? Color { get; set; }
        [StringLength(100)]
        public string? OwnerName { get; set; }
        [StringLength(100)]
        public string? OwnerAddress { get; set; }
        [StringLength(50)]
        public string? HotelCode { get; set; }
        [StringLength(100)]
        public string? HotelName1 { get; set; }
        [StringLength(100)]
        public string? HotelName2 { get; set; }
        [StringLength(50)]
        public string? FirstDriverCode { get; set; }
        [StringLength(100)]
        public string? DriverName1 { get; set; }
        [StringLength(100)]
        public string? DriverName2 { get; set; }
        [StringLength(50)]
        public string? SecondDriverCode { get; set; }
        [StringLength(100)]
        public string? SecondDriverName1 { get; set; }
        [StringLength(100)]
        public string? SecondDriverName2 { get; set; }
        [StringLength(50)]
        public string? ThirdDriverCode { get; set; }
        [StringLength(100)]
        public string? ThirdDriverName1 { get; set; }
        [StringLength(100)]
        public string? ThirdDriverName2 { get; set; }
        [StringLength(50)]
        public string? Nationality { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CustomerDateOfBirth { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CustomerCarLicenseExpiryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CustomerCarLicenseIssueDate { get; set; }
        [StringLength(50)]
        public string? CustomerCarLicenseNo { get; set; }
        [StringLength(50)]
        public string? CustomerCarLicenseIssuePlace { get; set; }
        public bool? CustomerInternationalLicense { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CustomerPassPortIssueDate { get; set; }
        [StringLength(50)]
        public string? CustomerPassPortIssuePlace { get; set; }
        [StringLength(50)]
        public string? CustomerPassPortNo { get; set; }
        [Column("CustID")]
        [StringLength(100)]
        public string? CustId { get; set; }
        [StringLength(30)]
        public string? FirstDriverDriverLicense { get; set; }
        [StringLength(30)]
        public string? FirstDriverLicenseDescription { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstDriverLicenseIssueDate { get; set; }
        [StringLength(255)]
        public string? FirstDriverLicenseLegalPlaceas { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstDriverLicenseRenewalDate { get; set; }
        [Column("FirstDriverID")]
        [StringLength(30)]
        public string? FirstDriverId { get; set; }
        [StringLength(100)]
        public string? PassPort { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstDriverDateOfBirth { get; set; }
        [Column("VAT", TypeName = "numeric(38, 10)")]
        public decimal? Vat { get; set; }
        public int? BookId { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
    }
}
