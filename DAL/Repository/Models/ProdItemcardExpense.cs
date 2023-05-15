using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_ItemcardExpenses")]
    public partial class ProdItemcardExpense
    {
        [Key]
        public int ProdExpensId { get; set; }
        public int? ItemCardId { get; set; }
        public int? AccountId { get; set; }
        public bool? IsPercent { get; set; }
        public byte? PercentOf { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenseValu { get; set; }

        [ForeignKey("ItemCardId")]
        [InverseProperty("ProdItemcardExpenses")]
        public virtual MsItemCard? ItemCard { get; set; }
    }
}
