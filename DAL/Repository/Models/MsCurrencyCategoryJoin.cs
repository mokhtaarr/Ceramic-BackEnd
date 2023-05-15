using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_CurrencyCategoryJoin")]
    public partial class MsCurrencyCategoryJoin
    {
        [Key]
        public int CurrencyCatJoinId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CurrencyCategoryId { get; set; }
        public byte? CurrencyType { get; set; }

        [ForeignKey("CurrencyId")]
        [InverseProperty("MsCurrencyCategoryJoins")]
        public virtual MsCurrency? Currency { get; set; }
        [ForeignKey("CurrencyCategoryId")]
        [InverseProperty("MsCurrencyCategoryJoins")]
        public virtual MsCurrencyCategory? CurrencyCategory { get; set; }
    }
}
