using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("WorkForc_TempIds")]
    public partial class WorkForcTempId
    {
        [Key]
        [Column("WFtempId")]
        public int WftempId { get; set; }
        public int? SeasonId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column("PersonID")]
        [StringLength(50)]
        public string? PersonId { get; set; }
        [StringLength(50)]
        public string? PassPortNo { get; set; }
        public int? JobId { get; set; }
        public bool? Succeeded { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Grade { get; set; }
        [Column(TypeName = "image")]
        public byte[]? PersonImage { get; set; }
        [StringLength(300)]
        public string? ImagePath { get; set; }
        public string? ImagePath2 { get; set; }
        [StringLength(300)]
        public string? ImagePath3 { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
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
        [StringLength(300)]
        public string? PersonImagePath { get; set; }
        public int? CustomerId { get; set; }
    }
}
