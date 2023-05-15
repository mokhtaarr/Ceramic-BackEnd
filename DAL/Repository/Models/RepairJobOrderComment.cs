using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Repair_JobOrderComments")]
    public partial class RepairJobOrderComment
    {
        [Key]
        public int RepairCommentsId { get; set; }
        public int? RepairId { get; set; }
        public int? EmpIdComBy { get; set; }
        [StringLength(500)]
        public string? Comment { get; set; }

        [ForeignKey("RepairId")]
        [InverseProperty("RepairJobOrderComments")]
        public virtual RepairJobOrder? Repair { get; set; }
    }
}
