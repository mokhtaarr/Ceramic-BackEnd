using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MsGA_ShipmentDetail")]
    public partial class MsGaShipmentDetail
    {
        [Key]
        public int ShipMentDetailId { get; set; }
        public int ShipMentId { get; set; }
        public int? LetterExportId { get; set; }
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

        [ForeignKey("LetterExportId")]
        [InverseProperty("MsGaShipmentDetails")]
        public virtual MsGaLetterExport? LetterExport { get; set; }
        [ForeignKey("ShipMentId")]
        [InverseProperty("MsGaShipmentDetails")]
        public virtual MsGaShipment ShipMent { get; set; } = null!;
    }
}
