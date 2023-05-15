using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MsGA_LetterExportDetail")]
    public partial class MsGaLetterExportDetail
    {
        [Key]
        public int LetExpDetailId { get; set; }
        public int? LetterExportId { get; set; }
        [StringLength(100)]
        public string? BuyerName { get; set; }
        [StringLength(200)]
        public string? BuyerAddress { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AddDate { get; set; }
        [StringLength(50)]
        public string? BuyerId { get; set; }
        public bool? IsCurrentBuyer { get; set; }
        [Column("colSalePrinted")]
        public bool? ColSalePrinted { get; set; }
        [Column("colQutPrinted")]
        public bool? ColQutPrinted { get; set; }
        [Column("colLetterPrinted")]
        public bool? ColLetterPrinted { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Image { get; set; }
        [StringLength(50)]
        public string? UserName { get; set; }
        [StringLength(50)]
        public string? FirstName { get; set; }
        public int? UserId { get; set; }
        [StringLength(200)]
        public string? AddField1 { get; set; }
        [StringLength(200)]
        public string? AddField2 { get; set; }
        [StringLength(100)]
        public string? AddField3 { get; set; }
        [StringLength(100)]
        public string? AddField4 { get; set; }

        [ForeignKey("LetterExportId")]
        [InverseProperty("MsGaLetterExportDetails")]
        public virtual MsGaLetterExport? LetterExport { get; set; }
    }
}
