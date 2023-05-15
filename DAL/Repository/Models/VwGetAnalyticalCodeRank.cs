using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetAnalyticalCodeRank
    {
        public long? RowRank { get; set; }
        [Column("AId")]
        public int Aid { get; set; }
        [StringLength(50)]
        public string Code { get; set; } = null!;
    }
}
