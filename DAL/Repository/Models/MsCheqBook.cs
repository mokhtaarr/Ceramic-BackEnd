using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_CheqBooks")]
    public partial class MsCheqBook
    {
        [Key]
        public int CheqBookId { get; set; }
        [StringLength(100)]
        public string? CheqBookCode { get; set; }
        [Column("CheqBookNamAR")]
        [StringLength(100)]
        public string? CheqBookNamAr { get; set; }
        [Column("CheqBookNamEN")]
        [StringLength(100)]
        public string? CheqBookNamEn { get; set; }
        public int? StartAt { get; set; }
        public int? CheqNum { get; set; }
        public int? CurrentNum { get; set; }
        public bool? Active { get; set; }
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
        public int? EmpId { get; set; }
        public bool? EmpDefaultBook { get; set; }

        [ForeignKey("EmpId")]
        [InverseProperty("MsCheqBooks")]
        public virtual HrEmployee? Emp { get; set; }
    }
}
