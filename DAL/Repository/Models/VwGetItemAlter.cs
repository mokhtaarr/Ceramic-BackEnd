using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetItemAlter
    {
        [StringLength(50)]
        public string? ItemCode { get; set; }
        [StringLength(100)]
        public string? ItemDescA { get; set; }
        [Column(TypeName = "decimal(38, 10)")]
        public decimal? Qty { get; set; }
        public int? ItemCardId { get; set; }
        [StringLength(50)]
        public string? AlterToCod { get; set; }
        [StringLength(100)]
        public string? AlterToDesc { get; set; }
    }
}
