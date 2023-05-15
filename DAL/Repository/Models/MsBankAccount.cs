using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_BankAccount")]
    public partial class MsBankAccount
    {
        public MsBankAccount()
        {
            MsBoxCurrencies = new HashSet<MsBoxCurrency>();
        }

        [Key]
        public int AccountId { get; set; }
        [StringLength(50)]
        public string? AcountCode { get; set; }
        [StringLength(100)]
        public string? AcounntNameA { get; set; }
        [StringLength(100)]
        public string? AcounntNameE { get; set; }

        [InverseProperty("Account")]
        public virtual ICollection<MsBoxCurrency> MsBoxCurrencies { get; set; }
    }
}
