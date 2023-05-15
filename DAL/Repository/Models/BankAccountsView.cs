using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class BankAccountsView
    {
        public int BoxCurrencyId { get; set; }
        [StringLength(50)]
        public string? AcountCode { get; set; }
        [StringLength(100)]
        public string? AcounntNameA { get; set; }
        [StringLength(50)]
        public string BoxCode { get; set; } = null!;
        [Column("DESCA")]
        [StringLength(100)]
        public string? Desca { get; set; }
    }
}
