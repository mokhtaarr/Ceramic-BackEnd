using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MsGA_LetterQuery")]
    public partial class MsGaLetterQuery
    {
        [Key]
        public int GawabQueryId { get; set; }
        public int? LetterNormId { get; set; }
        public int? StoreId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? AuthUser { get; set; }
        public bool? IsEdit { get; set; }
        public bool? EditDone { get; set; }
        public bool? IsPrint { get; set; }
        public int? CopyCount { get; set; }
        public int? PrintedCopy { get; set; }
        public int? RemainCopy { get; set; }
        public bool? CanEditBuyer { get; set; }
        [StringLength(500)]
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
        public int? PermPrinted { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PermPrintedAt { get; set; }
        public int? CreatedById { get; set; }
        public int? ShiftId { get; set; }
    }
}
