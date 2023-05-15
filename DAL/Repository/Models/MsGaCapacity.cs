using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MsGA_Capacity")]
    public partial class MsGaCapacity
    {
        [Key]
        public int CapcityId { get; set; }
        [StringLength(50)]
        public string? CapcityCode { get; set; }
        [StringLength(100)]
        public string? CapcityDescA { get; set; }
        [StringLength(100)]
        public string? CapcityDescE { get; set; }
        [StringLength(50)]
        public string? Size { get; set; }
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
    }
}
