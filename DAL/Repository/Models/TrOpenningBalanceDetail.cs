using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Tr_OpenningBalanceDetails")]
    public partial class TrOpenningBalanceDetail
    {
        [Key]
        public int OpeningBalanceDetailsId { get; set; }
        [Column("Tr_OpenningBalanceId")]
        public int? TrOpenningBalanceId { get; set; }
        public int? AccountId { get; set; }
        public int? LineNumber { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Creditor { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Debitor { get; set; }

        [ForeignKey("TrOpenningBalanceId")]
        [InverseProperty("TrOpenningBalanceDetails")]
        public virtual TrOpenningBalance? TrOpenningBalance { get; set; }
    }
}
