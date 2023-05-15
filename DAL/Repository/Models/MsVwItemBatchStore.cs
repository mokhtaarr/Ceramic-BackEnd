using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class MsVwItemBatchStore
    {
        [StringLength(50)]
        public string StoreCode { get; set; } = null!;
        [StringLength(100)]
        public string? StoreDescA { get; set; }
        [StringLength(100)]
        public string? StoreDescE { get; set; }
        public int StoreId { get; set; }
        public int ItemCardId { get; set; }
        public int ItemAtrribBatchId { get; set; }
    }
}
