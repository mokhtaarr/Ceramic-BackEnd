using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetPassPortRank
    {
        public long? RowRank { get; set; }
        [Column("WFPassPortId")]
        public int WfpassPortId { get; set; }
        [StringLength(50)]
        public string Code { get; set; } = null!;
        public int? SeasonId { get; set; }
    }
}
