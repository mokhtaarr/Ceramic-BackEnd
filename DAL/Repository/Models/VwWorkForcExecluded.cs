using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwWorkForcExecluded
    {
        public int BloodExecludId { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(100)]
        public string? CustomerDescE { get; set; }
        [StringLength(100)]
        public string? SeasonName2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EmbassyDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AcceptAgeFrom { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AcceptAgeTo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PassPortExpiry { get; set; }
    }
}
