using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sys_Books")]
    public partial class SysBook
    {
        [Key]
        public int BookId { get; set; }
        [StringLength(50)]
        public string? PrefixCode { get; set; }
        [Column("BookNameAR")]
        [StringLength(100)]
        public string? BookNameAr { get; set; }
        [Column("BookNameEN")]
        [StringLength(100)]
        public string? BookNameEn { get; set; }
        public byte? TermType { get; set; }
        public int? UserId { get; set; }
        public int? StoreId { get; set; }
        public bool? AutoSerial { get; set; }
        public bool? SystemIssuedOnly { get; set; }
        public bool? IsDefault { get; set; }
        public int? StartNum { get; set; }
        public int? EndNum { get; set; }
        public byte? PostType { get; set; }
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
    }
}
