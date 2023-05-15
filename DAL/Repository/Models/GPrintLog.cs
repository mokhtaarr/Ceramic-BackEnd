using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("G_PrintLog")]
    public partial class GPrintLog
    {
        [Key]
        public int PrintLogId { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PrintTime { get; set; }
        [StringLength(100)]
        public string? DocName { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
    }
}
