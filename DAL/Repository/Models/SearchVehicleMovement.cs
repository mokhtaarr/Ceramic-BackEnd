using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchVehicleMovement
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetTime { get; set; }
        [StringLength(100)]
        public string? AddField3 { get; set; }
        [StringLength(100)]
        public string? AddField4 { get; set; }
        [StringLength(100)]
        public string? AddField5 { get; set; }
        [StringLength(100)]
        public string? AddField6 { get; set; }
        [StringLength(100)]
        public string? AddField7 { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(50)]
        public string? VendorCode { get; set; }
        [StringLength(100)]
        public string? VendorDescA { get; set; }
        [StringLength(100)]
        public string? VendorDescE { get; set; }
        [StringLength(50)]
        public string? AnCode { get; set; }
        [StringLength(100)]
        public string? AnName { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public int? StorId { get; set; }
    }
}
