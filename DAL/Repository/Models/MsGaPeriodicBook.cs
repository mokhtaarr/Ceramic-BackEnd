using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MsGA_PeriodicBook")]
    public partial class MsGaPeriodicBook
    {
        public MsGaPeriodicBook()
        {
            MsGaPeriodicBookDetails = new HashSet<MsGaPeriodicBookDetail>();
        }

        [Key]
        public int PeriodicBookId { get; set; }
        public int? StoreId { get; set; }
        public int? CapcityId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? UserId { get; set; }
        [StringLength(1000)]
        public string? Remarks { get; set; }
        public int? SerialStart { get; set; }
        public int? SerialEnd { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? FirstLetter { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? LastLetter { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? PreFix { get; set; }
        public bool? Approved { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ApprovalDate { get; set; }
        public int? ApprovedBy { get; set; }
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
        public int? VendorId { get; set; }
        [StringLength(50)]
        public string? ManualTrNo { get; set; }
        public bool? BodyOrMotor { get; set; }
        [StringLength(200)]
        public string? Model { get; set; }
        [StringLength(1000)]
        public string? Logo1 { get; set; }
        [StringLength(1000)]
        public string? Logo2 { get; set; }
        [StringLength(1000)]
        public string? Logo3 { get; set; }
        [StringLength(1000)]
        public string? Cover1 { get; set; }
        [StringLength(1000)]
        public string? Cover2 { get; set; }
        public int? ShiftId { get; set; }

        [InverseProperty("PeriodicBook")]
        public virtual ICollection<MsGaPeriodicBookDetail> MsGaPeriodicBookDetails { get; set; }
    }
}
