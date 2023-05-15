using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_UnitReservationGuarantors")]
    public partial class ProjUnitReservationGuarantor
    {
        [Key]
        public int GuarantorId { get; set; }
        public int? ReservId { get; set; }
        public int? CustomerId { get; set; }
        [StringLength(100)]
        public string? ContactName1 { get; set; }
        [StringLength(100)]
        public string? ContactName2 { get; set; }
        [Column("IDNo")]
        [StringLength(20)]
        public string? Idno { get; set; }
        [StringLength(30)]
        public string? ContactPhone1 { get; set; }
        [StringLength(30)]
        public string? ContactPhone2 { get; set; }
        [StringLength(30)]
        public string? ContactPhone3 { get; set; }
        [StringLength(30)]
        public string? ContactPhone4 { get; set; }
        [StringLength(30)]
        public string? ContactPhone5 { get; set; }
        [StringLength(100)]
        public string? ContactAddress1 { get; set; }
        [StringLength(100)]
        public string? ContactAddress2 { get; set; }
        [StringLength(100)]
        public string? ContactAddress3 { get; set; }
        public int? AccountId1 { get; set; }
        public int? AccountId2 { get; set; }
        public int? AccountId3 { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? CostCenterId3 { get; set; }
        [StringLength(50)]
        public string? ContactCode { get; set; }
        public int? CityId { get; set; }
        [StringLength(100)]
        public string? ContactEmail1 { get; set; }
        [StringLength(100)]
        public string? ContactEmail2 { get; set; }
        [StringLength(100)]
        public string? ContactEmail3 { get; set; }
        [StringLength(50)]
        public string? PassPortNo { get; set; }
        [StringLength(100)]
        public string? Bank1 { get; set; }
        [StringLength(50)]
        public string? Bank2 { get; set; }
        [StringLength(50)]
        public string? Bank3 { get; set; }
        [StringLength(50)]
        public string? BankAccNo1 { get; set; }
        [StringLength(50)]
        public string? BankAccNo2 { get; set; }
        [StringLength(50)]
        public string? BankAccNo3 { get; set; }
        [StringLength(200)]
        public string? Remark1 { get; set; }
        [StringLength(200)]
        public string? Remark2 { get; set; }
        public bool? Isprimary { get; set; }

        [ForeignKey("ReservId")]
        [InverseProperty("ProjUnitReservationGuarantors")]
        public virtual ProjUnitReservation? Reserv { get; set; }
    }
}
