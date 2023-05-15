using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_UnitHistoryLog")]
    public partial class ProjUnitHistoryLog
    {
        [Key]
        public int ProjUnitHistoryId { get; set; }
        public int? ProjUnitId { get; set; }
        [StringLength(100)]
        public string? TableCode { get; set; }
        [StringLength(50)]
        public string? TableEntityIdName { get; set; }
        public long? TableEntityId { get; set; }
        [StringLength(100)]
        public string? LogActionDesc { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
