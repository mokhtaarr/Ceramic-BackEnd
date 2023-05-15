using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sys_Counter")]
    public partial class SysCounter
    {
        [Key]
        public int CounterId { get; set; }
        [StringLength(50)]
        public string? TrIdName { get; set; }
        public int? Counter { get; set; }
        public int? BookId { get; set; }
    }
}
