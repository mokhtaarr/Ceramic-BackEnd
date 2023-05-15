using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwHelpingAccountsSearch
    {
        [StringLength(100)]
        public string? AccountCode { get; set; }
        [StringLength(100)]
        public string? AccountNameA { get; set; }
        [StringLength(8)]
        [Unicode(false)]
        public string CustVendDesc { get; set; } = null!;
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceDepit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OpenningBalanceCredit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccCurrTrancDepit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AccCurrTrancCredit { get; set; }
        [StringLength(11)]
        [Unicode(false)]
        public string CustVendDesc2 { get; set; } = null!;
        [StringLength(100)]
        public string? AccountDescription { get; set; }
    }
}
