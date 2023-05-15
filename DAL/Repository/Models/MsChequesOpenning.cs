using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ChequesOpenning")]
    public partial class MsChequesOpenning
    {
        [Key]
        public int ChequeOpenId { get; set; }
        public bool? InOrOut { get; set; }
        public bool? IsKembiala { get; set; }
        [Column("beneficiaryAccId")]
        public int? BeneficiaryAccId { get; set; }
        public bool? IsHelpingAccount { get; set; }
        [StringLength(100)]
        public string? HelpTableName { get; set; }
        /// <summary>
        /// if Paper In [bank account and chartof account], if PaperOut [should be from book] and book is related to bank account which is related to account in chart of accounts
        /// </summary>
        public int? BoxCurrencyId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        public int? CurrencyId { get; set; }
        [Column(TypeName = "numeric(28, 7)")]
        public decimal? Value { get; set; }
        [Column(TypeName = "numeric(28, 7)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(28, 7)")]
        public decimal? ValueBeforeRate { get; set; }
        [StringLength(100)]
        public string? ChequeNumber { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }
        public byte? CheckType { get; set; }
        public int? CustomerId { get; set; }
        public int? VendorId { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }
    }
}
