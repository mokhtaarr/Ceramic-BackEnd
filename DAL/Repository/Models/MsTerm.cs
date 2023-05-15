using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_Terms")]
    public partial class MsTerm
    {
        public MsTerm()
        {
            MsTermsCostCenters = new HashSet<MsTermsCostCenter>();
            MsTermsDetails = new HashSet<MsTermsDetail>();
        }

        [Key]
        public int TermId { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? BookId { get; set; }
        public bool? SystemIssuedOnly { get; set; }
        public int? JournalEntryBookId { get; set; }
        public int? JournalEntryTermId { get; set; }
        public int? InventoryBookId { get; set; }
        public int? InventoryTermId { get; set; }
        public bool? IsOpenningTerm { get; set; }
        public bool? CashOrCredit { get; set; }
        public bool? IsStopped { get; set; }
        public bool? IsDefaultTerm { get; set; }
        public byte? UseItemTax { get; set; }
        [StringLength(500)]
        public string? ReportPath { get; set; }
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

        [InverseProperty("Term")]
        public virtual ICollection<MsTermsCostCenter> MsTermsCostCenters { get; set; }
        [InverseProperty("Term")]
        public virtual ICollection<MsTermsDetail> MsTermsDetails { get; set; }
    }
}
