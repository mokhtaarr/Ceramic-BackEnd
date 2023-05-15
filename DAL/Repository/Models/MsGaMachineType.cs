using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MsGA_MachineType")]
    public partial class MsGaMachineType
    {
        [Key]
        [Column("MachineID")]
        public int MachineId { get; set; }
        [StringLength(50)]
        public string MachineCode { get; set; } = null!;
        [StringLength(100)]
        public string? MachineName { get; set; }
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
        public int? VehicleShapeId { get; set; }
        public int? VehicleTypId { get; set; }
    }
}
