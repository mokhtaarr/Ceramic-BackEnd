using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class MsVwLetterDocSearch
    {
        public bool? LetterType { get; set; }
        [Column("BodySN")]
        [StringLength(200)]
        public string? BodySn { get; set; }
        [Column("MotorSN")]
        [StringLength(200)]
        public string? MotorSn { get; set; }
        [Column("MotorSNTrNo")]
        public int? MotorSntrNo { get; set; }
        public int? DeliverTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliverTrDate { get; set; }
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        public int? LetterTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LetterTrDate { get; set; }
        [StringLength(100)]
        public string? BuyerName { get; set; }
        public int? LetterId { get; set; }
        [Column("MotorSearialID")]
        public int MotorSearialId { get; set; }
        public int? StoreId { get; set; }
        [StringLength(100)]
        public string? CityName { get; set; }
        [StringLength(50)]
        public string? Size { get; set; }
        [StringLength(100)]
        public string? MachineName { get; set; }
        public string? MororName { get; set; }
        public bool? IsCurrentBuyer { get; set; }
        public int? IsTaxInvHold { get; set; }
    }
}
