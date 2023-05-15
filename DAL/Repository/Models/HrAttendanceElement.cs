using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_AttendanceElements")]
    public partial class HrAttendanceElement
    {
        [Key]
        public int AttendElementId { get; set; }
        [StringLength(50)]
        public string? ElementCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(100)]
        public string? UnitDescription { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FixedValue { get; set; }
        public byte? ValueType { get; set; }
        public byte? ElementUsage { get; set; }
        public byte? VacationEffect { get; set; }
        public bool? EnablEditOnEmpActivity { get; set; }
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
    }
}
