using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwSearchAllAccount
    {
        [StringLength(100)]
        public string? AccountCode { get; set; }
        [StringLength(100)]
        public string? AccountNameA { get; set; }
        public int? AccountLevel { get; set; }
        public bool? CalcMethod { get; set; }
        public int AccType { get; set; }
        [StringLength(16)]
        [Unicode(false)]
        public string AccDesc { get; set; } = null!;
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceDebitCurncy { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BalanceCreditCurncy { get; set; }
        public byte? AccountType { get; set; }
        public byte? AccountNature { get; set; }
        public byte? AccountGroup { get; set; }
        public byte? AccCashFlow { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string AccDesc2 { get; set; } = null!;
        [StringLength(100)]
        public string? AccountDescription { get; set; }
        public int AccountId { get; set; }
    }
}
