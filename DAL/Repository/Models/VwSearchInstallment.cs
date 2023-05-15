using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwSearchInstallment
    {
        [StringLength(50)]
        public string CustomerCode { get; set; } = null!;
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(100)]
        public string? CustomerDescE { get; set; }
        [Column("cc")]
        public int Cc { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(50)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? ContractTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ContractDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PayStartDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ActualSalesPrice { get; set; }
        public bool? PaidInCash { get; set; }
        public bool? IsContract { get; set; }
    }
}
