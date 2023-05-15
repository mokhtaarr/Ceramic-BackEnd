using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MsGA_LetterNormal")]
    public partial class MsGaLetterNormal
    {
        public MsGaLetterNormal()
        {
            MsGaLetterNormalDetails = new HashSet<MsGaLetterNormalDetail>();
            MsGaMotorSndetails = new HashSet<MsGaMotorSndetail>();
            MsGaPeriodicBookDetails = new HashSet<MsGaPeriodicBookDetail>();
        }

        [Key]
        public int LetterNormId { get; set; }
        public int? StoreId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(2000)]
        public string? Remarks { get; set; }
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
        [Column("client2")]
        [StringLength(100)]
        public string? Client2 { get; set; }
        public bool? TaxPrinted { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
        public int? BodyPeriodicBookId { get; set; }
        public int? MotorPeriodicBookId { get; set; }
        public bool? BookMotorPrint { get; set; }
        public bool? BookBodyPrint { get; set; }
        public bool? ApprovedBookMotor { get; set; }
        public bool? ApprovedBookBody { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BookMotorPrintTime { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BookBodyPrintTime { get; set; }
        [StringLength(100)]
        public string? LogoPrintedMotor { get; set; }
        [StringLength(100)]
        public string? LogoPrintedBody { get; set; }
        public bool? IsOurBody { get; set; }
        public int? ShiftId { get; set; }
        public int? ColorId { get; set; }
        public int? VehicleShapeId { get; set; }
        public int? VehicleTypId { get; set; }

        [InverseProperty("LetterNorm")]
        public virtual ICollection<MsGaLetterNormalDetail> MsGaLetterNormalDetails { get; set; }
        [InverseProperty("LetterNorm")]
        public virtual ICollection<MsGaMotorSndetail> MsGaMotorSndetails { get; set; }
        [InverseProperty("LetterNorm")]
        public virtual ICollection<MsGaPeriodicBookDetail> MsGaPeriodicBookDetails { get; set; }
    }
}
