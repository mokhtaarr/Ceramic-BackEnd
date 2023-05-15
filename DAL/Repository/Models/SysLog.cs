using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("SysLog")]
    public partial class SysLog
    {
        [Key]
        [Column("LogID")]
        public long LogId { get; set; }
        [StringLength(100)]
        public string? TablName { get; set; }
        public int? UserId { get; set; }
        public int? RowIndex { get; set; }
        [StringLength(100)]
        public string? LogAction { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LogDate { get; set; }
        [StringLength(100)]
        public string? ScreenName { get; set; }
        [StringLength(100)]
        public string? ScreenNameAr { get; set; }
        [StringLength(100)]
        public string? TablDetailName { get; set; }
        [StringLength(100)]
        public string? FieldName { get; set; }
        [StringLength(100)]
        public string? FieldNameAr { get; set; }
        [StringLength(1000)]
        public string? FieldDetail { get; set; }
        [StringLength(2000)]
        public string? OldValue { get; set; }
        [StringLength(2000)]
        public string? NewValue { get; set; }
    }
}
