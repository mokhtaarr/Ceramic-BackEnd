using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_Attachments")]
    public partial class MsAttachment
    {
        [Key]
        public int AttachId { get; set; }
        [StringLength(50)]
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        [StringLength(50)]
        public string? AttachType { get; set; }
        [StringLength(500)]
        public string? AttachPath { get; set; }
        [StringLength(500)]
        public string? AttachPath2 { get; set; }
        [StringLength(255)]
        public string? AttachDesc1 { get; set; }
        [StringLength(255)]
        public string? AttachDesc2 { get; set; }
        public int? AttachSerial { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? IssueDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpiryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RenewalDate { get; set; }
        [StringLength(100)]
        public string? IssuePlace { get; set; }
        public bool? Encrypted { get; set; }
        [StringLength(500)]
        public string? EncyptionDesc { get; set; }
    }
}
