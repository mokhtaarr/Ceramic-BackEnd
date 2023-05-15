using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwAllVehicleJobOrdersDoc
    {
        [Column("VJOrderId")]
        public int VjorderId { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(17)]
        [Unicode(false)]
        public string DocType { get; set; } = null!;
        [StringLength(11)]
        [Unicode(false)]
        public string DocTypeName1 { get; set; } = null!;
        [StringLength(16)]
        [Unicode(false)]
        public string DocTypeName2 { get; set; } = null!;
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [StringLength(200)]
        public string? DocRemarks { get; set; }
        [StringLength(50)]
        public string? CurrencyCode { get; set; }
        [StringLength(100)]
        public string? CurrencyDescA { get; set; }
        public bool? DefualtCurrency { get; set; }
        [StringLength(50)]
        public string? CurrencySymbol { get; set; }
        [Column(TypeName = "numeric(38, 6)")]
        public decimal? DocValue { get; set; }
    }
}
