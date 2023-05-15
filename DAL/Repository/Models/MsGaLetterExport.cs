using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MsGA_LetterExport")]
    public partial class MsGaLetterExport
    {
        public MsGaLetterExport()
        {
            MsGaLetterExportDetails = new HashSet<MsGaLetterExportDetail>();
            MsGaShipmentDetails = new HashSet<MsGaShipmentDetail>();
        }

        [Key]
        public int LetterExportId { get; set; }
        public int? StoreId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? CustomerId { get; set; }
        public int? DeliverId { get; set; }
        [StringLength(50)]
        public string? CustomsNo { get; set; }
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
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }

        [InverseProperty("LetterExport")]
        public virtual ICollection<MsGaLetterExportDetail> MsGaLetterExportDetails { get; set; }
        [InverseProperty("LetterExport")]
        public virtual ICollection<MsGaShipmentDetail> MsGaShipmentDetails { get; set; }
    }
}
