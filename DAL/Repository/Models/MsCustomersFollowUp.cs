using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_CustomersFollowUp")]
    public partial class MsCustomersFollowUp
    {
        [Key]
        public int FollowUpUpdateId { get; set; }
        public int? CustomerId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? FollowUpTypeId { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? ValidityDays { get; set; }
        [StringLength(2000)]
        public string? Remarks { get; set; }
        [StringLength(200)]
        public string? AddField1 { get; set; }
        [StringLength(200)]
        public string? AddField2 { get; set; }
        [StringLength(200)]
        public string? AddField3 { get; set; }
        [StringLength(200)]
        public string? AddField4 { get; set; }
        [StringLength(200)]
        public string? AddField5 { get; set; }
        [StringLength(200)]
        public string? AddField6 { get; set; }
        [StringLength(200)]
        public string? AddField7 { get; set; }
        [StringLength(200)]
        public string? AddField8 { get; set; }
        [StringLength(200)]
        public string? AddField9 { get; set; }
        [StringLength(200)]
        public string? AddField10 { get; set; }
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
        public int? PermPrinted { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PermPrintedAt { get; set; }
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

        [ForeignKey("CustomerId")]
        [InverseProperty("MsCustomersFollowUps")]
        public virtual MsCustomer? Customer { get; set; }
    }
}
