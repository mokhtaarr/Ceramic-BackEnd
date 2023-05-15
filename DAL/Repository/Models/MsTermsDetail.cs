using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_TermsDetails")]
    public partial class MsTermsDetail
    {
        [Key]
        public int TermDetailId { get; set; }
        public int? TermId { get; set; }
        public int? AccountIdDebit { get; set; }
        public byte? AccountDebitFixed { get; set; }
        public int? CostCenterIdDebit { get; set; }
        public byte? CostCenterDebitFixed { get; set; }
        [StringLength(50)]
        public string? ValuAccountDebit { get; set; }
        public int? AccountIdCredit { get; set; }
        public byte? AccountCreditFixed { get; set; }
        public int? CostCenterIdCredit { get; set; }
        public byte? CostCenterCreditFixed { get; set; }
        [StringLength(50)]
        public string? ValuAccountCredit { get; set; }
        public int? AccountIdDisc { get; set; }
        public byte? AccountDiscIsFixed { get; set; }
        public int? CostCenterIdDisc { get; set; }
        public byte? CostCenterDiscIsFixed { get; set; }
        [StringLength(50)]
        public string? ValuAccountDisc { get; set; }
        public int? AccountIdCash { get; set; }
        public byte? AccountCashIsFixed { get; set; }
        public int? CostCenterIdCash { get; set; }
        public byte? CostCenterCashIsFixed { get; set; }
        [StringLength(50)]
        public string? ValuAccountCash { get; set; }
        public int? AccountIdTax { get; set; }
        public byte? AccountTaxIsFixed { get; set; }
        public int? CostCenterIdTax { get; set; }
        public byte? CostCenterTaxIsFixed { get; set; }
        [StringLength(50)]
        public string? ValuAccountTax { get; set; }
        public bool? AccDiscDebitOrCredit { get; set; }
        public bool? AccCashDebitOrCredit { get; set; }
        public bool? AccTaxDebitOrCredit { get; set; }
        public int? AddAccountId1 { get; set; }
        public byte? AddAccount1IsFixed { get; set; }
        public int? AddCostCenterId1 { get; set; }
        public byte? AddCostCenter1IsFixed { get; set; }
        [StringLength(50)]
        public string? ValuAddAccount1 { get; set; }
        public int? AddAccountId2 { get; set; }
        public byte? AddAccountIsFixed2 { get; set; }
        public int? AddCostCenterId2 { get; set; }
        public byte? AddCostCenterIsFixed2 { get; set; }
        [StringLength(50)]
        public string? ValuAddAccount2 { get; set; }
        public int? AddAccountId3 { get; set; }
        public byte? AddAccountIsFixed3 { get; set; }
        public int? AddCostCenterId3 { get; set; }
        public byte? AddCostCenterIsFixed3 { get; set; }
        [StringLength(50)]
        public string? ValuAddAccount3 { get; set; }
        public int? AddAccountId4 { get; set; }
        public byte? AddAccountIsFixed4 { get; set; }
        public int? AddCostCenterId4 { get; set; }
        public byte? AddCostCenterIsFixed4 { get; set; }
        [StringLength(50)]
        public string? ValuAddAccount4 { get; set; }
        public int? AddAccountId5 { get; set; }
        public byte? AddAccountIsFixed5 { get; set; }
        public int? AddCostCenterId5 { get; set; }
        public byte? AddCostCenterIsFixed5 { get; set; }
        [StringLength(50)]
        public string? ValuAddAccount5 { get; set; }
        public bool? AddAcc1DebitOrCredit { get; set; }
        public bool? AddAcc2DebitOrCredit { get; set; }
        public bool? AddAcc3DebitOrCredit { get; set; }
        public bool? AddAcc4DebitOrCredit { get; set; }
        public bool? AddAcc5DebitOrCredit { get; set; }
        public bool? AnalaticalCodeMust { get; set; }

        [ForeignKey("TermId")]
        [InverseProperty("MsTermsDetails")]
        public virtual MsTerm? Term { get; set; }
    }
}
