using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_PosPaymentMethods")]
    public partial class MsPosPaymentMethod
    {
        [Key]
        public int PayMethodId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AddPercent { get; set; }
        [Column(TypeName = "image")]
        public byte[]? MethodImage { get; set; }
        [StringLength(250)]
        public string? Desc1 { get; set; }
        [StringLength(250)]
        public string? Desc2 { get; set; }
        public bool? MandatoryFieldData { get; set; }
        [StringLength(250)]
        public string? UserQuestion { get; set; }
    }
}
