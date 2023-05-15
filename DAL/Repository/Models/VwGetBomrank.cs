using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetBomrank
    {
        public long? RowRank { get; set; }
        public int BillOfMaterialId { get; set; }
        [Column("BOMCode")]
        [StringLength(50)]
        public string? Bomcode { get; set; }
    }
}
