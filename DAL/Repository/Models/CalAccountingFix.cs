using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_AccountingFix")]
    public partial class CalAccountingFix
    {
        [Key]
        public int AccRecalcId { get; set; }
        public int? UserId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(2000)]
        public string? Reason { get; set; }
    }
}
