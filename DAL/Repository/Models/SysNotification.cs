using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sys_Notifications")]
    public partial class SysNotification
    {
        [Key]
        public int NotiFyId { get; set; }
        public int? NotifyTypeId { get; set; }
        [StringLength(100)]
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        public int? TableEntityDetailId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? NextNotify { get; set; }
        [StringLength(200)]
        public string? NotifyMessage { get; set; }
        public bool? Closed { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        [StringLength(255)]
        public string? RemarksA { get; set; }
        [StringLength(255)]
        public string? RemarksE { get; set; }
    }
}
