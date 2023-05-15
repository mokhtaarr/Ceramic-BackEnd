using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class MsVwLetterTaxSearch
    {
        public int? LetterTaxTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LetterTaxTrDate { get; set; }
        public int? LetterNormalTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LetterNormalTrDate { get; set; }
        [StringLength(100)]
        public string? BuyerName { get; set; }
        [StringLength(50)]
        public string? BuyerId { get; set; }
        [Column("MotorSN")]
        [StringLength(200)]
        public string? MotorSn { get; set; }
        [Column("BodySN")]
        [StringLength(200)]
        public string? BodySn { get; set; }
        [StringLength(100)]
        public string? TempDesca { get; set; }
        [Column(TypeName = "numeric(22, 2)")]
        public decimal? TaxValu { get; set; }
    }
}
