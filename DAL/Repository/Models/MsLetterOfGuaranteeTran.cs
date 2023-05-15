using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_LetterOfGuaranteeTrans")]
    public partial class MsLetterOfGuaranteeTran
    {
        [Key]
        public int LetOfGrnteeTranId { get; set; }
        public int? LetOfGrnteeId { get; set; }
        public int? StoreId { get; set; }
        public int? LetOfGrnteeStatusId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? CurrencyId { get; set; }
        public int? LetOfGrnteeTypeId { get; set; }
        public int? LetOfGrnteeCatId { get; set; }
        public int? LetOfGrnteeStatusId1 { get; set; }
        public byte? PaperDirection { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [Column("DBTableName")]
        [StringLength(100)]
        public string? DbtableName { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [Column("DBTableId")]
        public int? DbtableId { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [StringLength(100)]
        public string? AccountTableName { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? AccountId { get; set; }
        public int? BankAccountId { get; set; }
        public byte? ResourceType { get; set; }
        public int? ResourceId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        [Column("LetrOfGAccountId")]
        public int? LetrOfGaccountId { get; set; }
        [Column("LetrOfGExpensAccountId")]
        public int? LetrOfGexpensAccountId { get; set; }
        [Column("LetrOfGCommisionAccountId")]
        public int? LetrOfGcommisionAccountId { get; set; }
        [StringLength(200)]
        public string? Description { get; set; }
        [StringLength(200)]
        public string? ReceiverName { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ValueBeforeRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Commision { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CashMargin { get; set; }
        public bool? IsCovered { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoverPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoverValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Expenses { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LimitGuarantee { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CustodyGuarantee { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LetEndDate { get; set; }
        [StringLength(1500)]
        public string? Conditions { get; set; }
        /// <summary>
        /// 1 Uprais,2 Decreas, else none
        /// </summary>
        public byte? ValuEffect { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
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

        [ForeignKey("LetOfGrnteeId")]
        [InverseProperty("MsLetterOfGuaranteeTrans")]
        public virtual MsLetterOfGuarantee? LetOfGrntee { get; set; }
    }
}
