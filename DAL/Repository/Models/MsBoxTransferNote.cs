using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_BoxTransferNote")]
    public partial class MsBoxTransferNote
    {
        public MsBoxTransferNote()
        {
            MsBoxTransferDetails = new HashSet<MsBoxTransferDetail>();
        }

        [Key]
        public int BoxTranId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public bool? IsBox { get; set; }
        [Column("strCustm1")]
        [StringLength(100)]
        public string? StrCustm1 { get; set; }
        [Column("strCustm2")]
        [StringLength(100)]
        public string? StrCustm2 { get; set; }
        [Column("strCustm3")]
        [StringLength(100)]
        public string? StrCustm3 { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }

        [InverseProperty("BoxTran")]
        public virtual ICollection<MsBoxTransferDetail> MsBoxTransferDetails { get; set; }
    }
}
