using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwAttendTime
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("code")]
        public int? Code { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string? Name { get; set; }
        [Column("dateat", TypeName = "date")]
        public DateTime? Dateat { get; set; }
        [Column("timeat")]
        public TimeSpan? Timeat { get; set; }
        [Column("mode")]
        public int? Mode { get; set; }
        [Column("countleate", TypeName = "decimal(18, 0)")]
        public decimal? Countleate { get; set; }
        [Column("Dev_id")]
        public int? DevId { get; set; }
        [Column("rol_id")]
        public int? RolId { get; set; }
        [Column("moderol")]
        [StringLength(50)]
        public string? Moderol { get; set; }
        [Column("countearly", TypeName = "decimal(18, 0)")]
        public decimal? Countearly { get; set; }
        [Column("countearlypure", TypeName = "decimal(18, 0)")]
        public decimal? Countearlypure { get; set; }
        [Column("countovertim", TypeName = "decimal(18, 0)")]
        public decimal? Countovertim { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NewAttend { get; set; }
    }
}
