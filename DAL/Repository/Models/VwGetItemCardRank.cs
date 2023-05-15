using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetItemCardRank
    {
        public long? RowRank { get; set; }
        public int ItemCardId { get; set; }
        [StringLength(50)]
        public string? ItemCode { get; set; }
    }
}
