using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetCurrencyRank
    {
        public long? RowRank { get; set; }
        public int CurrencyId { get; set; }
        [StringLength(50)]
        public string CurrencyCode { get; set; } = null!;
    }
}
