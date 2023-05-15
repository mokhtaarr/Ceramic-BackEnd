using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_Company")]
    public partial class MsCompany
    {
        [Key]
        public int CompanyId { get; set; }
        [Column("code")]
        public int? Code { get; set; }
        [StringLength(50)]
        public string? CompShortNameA { get; set; }
        [StringLength(50)]
        public string? CompShortNameE { get; set; }
        [StringLength(100)]
        public string? CompNameA { get; set; }
        [StringLength(100)]
        public string? CompNameE { get; set; }
        [StringLength(100)]
        public string? OwnerName { get; set; }
        [StringLength(50)]
        public string? PostalCode { get; set; }
        public int? RegionId { get; set; }
        [StringLength(150)]
        public string? MailBox { get; set; }
        [StringLength(255)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string? Tel1 { get; set; }
        [StringLength(50)]
        public string? Tel2 { get; set; }
        [StringLength(50)]
        public string? Tel3 { get; set; }
        [StringLength(50)]
        public string? Tel4 { get; set; }
        [StringLength(50)]
        public string? Fax1 { get; set; }
        [StringLength(50)]
        public string? Fax2 { get; set; }
        [StringLength(50)]
        public string? Fax3 { get; set; }
        [StringLength(50)]
        public string? Fax4 { get; set; }
        [StringLength(50)]
        public string? Mobile { get; set; }
        [StringLength(50)]
        public string? Mobile1 { get; set; }
        [StringLength(50)]
        public string? Mobile2 { get; set; }
        [StringLength(50)]
        public string? Mobile3 { get; set; }
        [StringLength(100)]
        public string? Email { get; set; }
        [StringLength(100)]
        public string? Email1 { get; set; }
        [StringLength(100)]
        public string? Email2 { get; set; }
        [StringLength(100)]
        public string? Email3 { get; set; }
        [StringLength(100)]
        public string? Website { get; set; }
        [StringLength(100)]
        public string? Website3 { get; set; }
        [StringLength(100)]
        public string? Website2 { get; set; }
        [StringLength(100)]
        public string? Website1 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DateOfEstablishment { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Logo { get; set; }
        [StringLength(255)]
        public string? LegalEntity { get; set; }
        [StringLength(255)]
        public string? RemarksA { get; set; }
        [StringLength(255)]
        public string? RemarksE { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? YearStartfrom { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? YearEndTo { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
    }
}
