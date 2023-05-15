using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ReservInstallments")]
    public partial class ProjReservInstallment
    {
        [Key]
        public int ReservInstallId { get; set; }
        public int? ReservId { get; set; }
        public int? Serial { get; set; }
        public int? InstallTempDetailId { get; set; }
        public int? PayTypeId { get; set; }
        public int? ResourceId { get; set; }
        public byte? ResourceType { get; set; }
        public int? ResourceAccountId { get; set; }
        public int? ProjUnitServiceId { get; set; }
        public int? UnitServId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InstallValu { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidCash { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidCheques { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidBankDeposit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NotPaid { get; set; }
        public bool? IsPaid { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PaidDate { get; set; }
        public int? DelayDays { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DelayFine { get; set; }
        public int? RectId { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        public bool? Deleted { get; set; }
        [StringLength(100)]
        public string? DeletReason { get; set; }

        [ForeignKey("ReservId")]
        [InverseProperty("ProjReservInstallments")]
        public virtual ProjUnitReservation? Reserv { get; set; }
    }
}
