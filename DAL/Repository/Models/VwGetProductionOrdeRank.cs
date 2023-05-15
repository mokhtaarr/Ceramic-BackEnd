using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetProductionOrdeRank
    {
        public long? RowRank { get; set; }
        public int ProductionOrderId { get; set; }
        public int TrNo { get; set; }
    }
}
