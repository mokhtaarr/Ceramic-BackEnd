using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetVendorsRank
    {
        public long? RowRank { get; set; }
        public int VendorId { get; set; }
        [StringLength(50)]
        public string VendorCode { get; set; } = null!;
    }
}
