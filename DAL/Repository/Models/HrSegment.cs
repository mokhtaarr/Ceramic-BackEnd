using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_Segments")]
    public partial class HrSegment
    {
        [Key]
        public int SegmentId { get; set; }
        public int? SalaryTypId { get; set; }
        public byte? SegmentSerial { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FromSegmant { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ToSegmant { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SegmantPercent { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }

        [ForeignKey("SalaryTypId")]
        [InverseProperty("HrSegments")]
        public virtual HrSalaryType? SalaryTyp { get; set; }
    }
}
