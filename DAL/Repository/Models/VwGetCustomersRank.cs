using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetCustomersRank
    {
        public long? RowRank { get; set; }
        public int CustomerId { get; set; }
        [StringLength(50)]
        public string CustomerCode { get; set; } = null!;
    }
}
