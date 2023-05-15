using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetAssetRank
    {
        public long? RowRank { get; set; }
        public int AssetId { get; set; }
        [StringLength(50)]
        public string? AssetCode { get; set; }
    }
}
