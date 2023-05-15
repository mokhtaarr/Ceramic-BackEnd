using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_JurnalDetail")]
    public partial class CalJurnalDetail
    {
        [Key]
        public int JurnalDetailId { get; set; }
        public int? JurnalId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? AccountId { get; set; }
        public int? CustAccountId { get; set; }
        public int? VendAccountId { get; set; }
        public int? EmpAccountId { get; set; }
        public int? AssetAccountId { get; set; }
        public int? BusinessPartnerAccId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? CostCenterId3 { get; set; }
        public int? CostCenterId4 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [StringLength(150)]
        public string? JurDesc { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DebitCurrency { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditCurrency { get; set; }
        public int? CurrencyId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DebitLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditLocal { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }

        [ForeignKey("CurrencyId")]
        [InverseProperty("CalJurnalDetails")]
        public virtual MsCurrency? Currency { get; set; }
        [ForeignKey("JurnalId")]
        [InverseProperty("CalJurnalDetails")]
        public virtual CalJurnalEntry? Jurnal { get; set; }
    }
}
