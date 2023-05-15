using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MsGA_PeriodicBookDetail")]
    public partial class MsGaPeriodicBookDetail
    {
        [Key]
        public int PeriodicBookDetailId { get; set; }
        public int? PeriodicBookId { get; set; }
        public int? LetterNormId { get; set; }
        public int? Serial { get; set; }
        [Column("MotorSN")]
        [StringLength(200)]
        public string? MotorSn { get; set; }
        [Column("BodySN")]
        [StringLength(200)]
        public string? BodySn { get; set; }
        [Column("MororID")]
        public int? MororId { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        public int? CapcityId { get; set; }
        [Column("MachineID")]
        public int? MachineId { get; set; }
        /// <summary>
        /// 0 Cash ; 1 Installment
        /// </summary>
        public byte? BasicSaleType { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(50)]
        public string? Model { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }

        [ForeignKey("LetterNormId")]
        [InverseProperty("MsGaPeriodicBookDetails")]
        public virtual MsGaLetterNormal? LetterNorm { get; set; }
        [ForeignKey("PeriodicBookId")]
        [InverseProperty("MsGaPeriodicBookDetails")]
        public virtual MsGaPeriodicBook? PeriodicBook { get; set; }
    }
}
