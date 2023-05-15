using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ChequeTransferDetail")]
    public partial class MsChequeTransferDetail
    {
        [Key]
        public int ChequTranDetailId { get; set; }
        public int? RectId { get; set; }
        public int? CustomerId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? BalanceAfter { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }
    }
}
