using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("WorkForc_Seasons")]
    public partial class WorkForcSeason
    {
        [Key]
        public int SeasonId { get; set; }
        [StringLength(50)]
        public string? SeasonCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EmbassyDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AcceptAgeFrom { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AcceptAgeTo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PassPortExpiry { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        [StringLength(50)]
        public string? CountryEnc { get; set; }
        public bool? IsCurrentSeason { get; set; }
        public bool? IsPreviousSeason { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
    }
}
