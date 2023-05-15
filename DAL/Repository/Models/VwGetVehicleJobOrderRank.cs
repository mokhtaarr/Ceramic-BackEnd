using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetVehicleJobOrderRank
    {
        public long? RowRank { get; set; }
        [Column("VJOrderId")]
        public int VjorderId { get; set; }
        public int? BookId { get; set; }
        public int? TrNo { get; set; }
    }
}
