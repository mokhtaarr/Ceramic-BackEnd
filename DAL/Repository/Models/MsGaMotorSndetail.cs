using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MsGA_MotorSNDetail")]
    public partial class MsGaMotorSndetail
    {
        [Key]
        [Column("MotorSearialID")]
        public int MotorSearialId { get; set; }
        public int? MotorDocId { get; set; }
        public int? LetterNormId { get; set; }
        public int? LetterFayumId { get; set; }
        [Column("MororID")]
        public int? MororId { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        public int? CapcityId { get; set; }
        [Column("MachineID")]
        public int? MachineId { get; set; }
        [Column("MotorSN")]
        [StringLength(200)]
        public string? MotorSn { get; set; }
        [Column("BodySN")]
        [StringLength(200)]
        public string? BodySn { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        /// <summary>
        /// 0 Cash ; 1 Installment
        /// </summary>
        public byte? BasicSaleType { get; set; }
        public bool? LetterType { get; set; }
        [StringLength(50)]
        public string? Model { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }

        [ForeignKey("LetterFayumId")]
        [InverseProperty("MsGaMotorSndetails")]
        public virtual MsGaLetterFayum? LetterFayum { get; set; }
        [ForeignKey("LetterNormId")]
        [InverseProperty("MsGaMotorSndetails")]
        public virtual MsGaLetterNormal? LetterNorm { get; set; }
        [ForeignKey("MotorDocId")]
        [InverseProperty("MsGaMotorSndetails")]
        public virtual MsGaMotorSn? MotorDoc { get; set; }
    }
}
