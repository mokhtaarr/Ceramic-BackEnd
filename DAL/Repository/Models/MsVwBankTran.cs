using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class MsVwBankTran
    {
        public int BoxTranDetailId { get; set; }
        public int? BoxTranId { get; set; }
        [StringLength(50)]
        public string? BoxFrom { get; set; }
        [Column("DESCA")]
        [StringLength(100)]
        public string? Desca { get; set; }
        [StringLength(50)]
        public string? BoxTo { get; set; }
        [Column("DESCE")]
        [StringLength(100)]
        public string? Desce { get; set; }
        [Column("valu", TypeName = "numeric(38, 10)")]
        public decimal? Valu { get; set; }
    }
}
