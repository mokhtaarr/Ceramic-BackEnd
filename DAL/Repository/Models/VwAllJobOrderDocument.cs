using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwAllJobOrderDocument
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column("docval", TypeName = "numeric(38, 10)")]
        public decimal? Docval { get; set; }
    }
}
