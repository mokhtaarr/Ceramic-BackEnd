using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_BoxCurrency")]
    public partial class MsBoxCurrency
    {
        [Key]
        public int BoxCurrencyId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BoxId { get; set; }
        public int? AccountId { get; set; }
        public int? AccountChrtId { get; set; }
        public int? RetAccountId { get; set; }
        public int? BankExpensAccId { get; set; }
        public int? ChequndercollectId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey("AccountId")]
        [InverseProperty("MsBoxCurrencies")]
        public virtual MsBankAccount? Account { get; set; }
        [ForeignKey("BoxId")]
        [InverseProperty("MsBoxCurrencies")]
        public virtual MsBoxBank? Box { get; set; }
        [ForeignKey("CurrencyId")]
        [InverseProperty("MsBoxCurrencies")]
        public virtual MsCurrency? Currency { get; set; }
    }
}
