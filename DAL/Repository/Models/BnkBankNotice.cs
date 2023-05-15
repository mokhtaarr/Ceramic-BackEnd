using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("BNk_BankNotice")]
    public partial class BnkBankNotice
    {
        public BnkBankNotice()
        {
            BnkBankNoticeDetails = new HashSet<BnkBankNoticeDetail>();
        }

        [Key]
        public int BankNoticId { get; set; }
        public int? StoreId { get; set; }
        public int? CurrencyId { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(100)]
        public string? KeeperNo { get; set; }
        public int? BoxId { get; set; }
        public int? AccountId { get; set; }
        public bool? IsReceived { get; set; }
        public int? RefNo { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCheques { get; set; }
        public bool? PaperDirection { get; set; }
        public byte? TranType { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BankExpenses { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
        public bool? Closed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
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

        [InverseProperty("BankNotic")]
        public virtual ICollection<BnkBankNoticeDetail> BnkBankNoticeDetails { get; set; }
    }
}
