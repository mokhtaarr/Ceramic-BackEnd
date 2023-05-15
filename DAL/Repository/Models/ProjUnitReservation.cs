using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_UnitReservation")]
    public partial class ProjUnitReservation
    {
        public ProjUnitReservation()
        {
            ProjProjUnitServices = new HashSet<ProjProjUnitService>();
            ProjReservInstallments = new HashSet<ProjReservInstallment>();
            ProjReserveUnitDocuments = new HashSet<ProjReserveUnitDocument>();
            ProjReserveUnitOwners = new HashSet<ProjReserveUnitOwner>();
            ProjReserveUnitSellers = new HashSet<ProjReserveUnitSeller>();
            ProjUnitReservationGuarantors = new HashSet<ProjUnitReservationGuarantor>();
        }

        [Key]
        public int ReservId { get; set; }
        public int? StoreId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? InstallTempId { get; set; }
        public int? InstallId { get; set; }
        public int? ContractTypeId { get; set; }
        public int? CustomerId { get; set; }
        public bool? IsCustBalancInstall { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CustomerBalace { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? TrNo { get; set; }
        [StringLength(50)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        public int? ContractTrNo { get; set; }
        public int? ContractBookId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ContractDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PayStartDate { get; set; }
        public int? ProjUnitId { get; set; }
        public int? ProjectId { get; set; }
        public int? SalesEmpId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitMeterPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitArea { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitPrice { get; set; }
        public bool? PaidInCash { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ActualSalesPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalInstallments { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NotPaidInstallments { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CommissionPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CommissionValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LeavePercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LeaveValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FeesPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FeesValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FinishMeterPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FinishValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalServices { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalUnitArea { get; set; }
        public bool? IsContract { get; set; }
        /// <summary>
        /// 0 without,1=10,2=100,3=1000,4=10000
        /// </summary>
        public byte? RoundType { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        public bool? IsRental { get; set; }
        public bool? Closed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NotPaid { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
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
        [StringLength(100)]
        public string? AddField8 { get; set; }
        [StringLength(100)]
        public string? AddField9 { get; set; }
        [StringLength(100)]
        public string? AddField10 { get; set; }
        public int? ShiftId { get; set; }
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

        [InverseProperty("Reserv")]
        public virtual ICollection<ProjProjUnitService> ProjProjUnitServices { get; set; }
        [InverseProperty("Reserv")]
        public virtual ICollection<ProjReservInstallment> ProjReservInstallments { get; set; }
        [InverseProperty("Reserv")]
        public virtual ICollection<ProjReserveUnitDocument> ProjReserveUnitDocuments { get; set; }
        [InverseProperty("Reserv")]
        public virtual ICollection<ProjReserveUnitOwner> ProjReserveUnitOwners { get; set; }
        [InverseProperty("Reserv")]
        public virtual ICollection<ProjReserveUnitSeller> ProjReserveUnitSellers { get; set; }
        [InverseProperty("Reserv")]
        public virtual ICollection<ProjUnitReservationGuarantor> ProjUnitReservationGuarantors { get; set; }
    }
}
