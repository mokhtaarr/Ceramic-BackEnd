using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MsGA_MotorSN")]
    public partial class MsGaMotorSn
    {
        public MsGaMotorSn()
        {
            MsGaMotorSndetails = new HashSet<MsGaMotorSndetail>();
        }

        [Key]
        public int MotorDocId { get; set; }
        public int? StoreId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? StockRecId { get; set; }
        public bool? IsMotor { get; set; }
        [StringLength(1000)]
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
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
        public int? ShiftId { get; set; }

        [InverseProperty("MotorDoc")]
        public virtual ICollection<MsGaMotorSndetail> MsGaMotorSndetails { get; set; }
    }
}
