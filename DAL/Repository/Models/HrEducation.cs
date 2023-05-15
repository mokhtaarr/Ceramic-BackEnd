using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_Education")]
    public partial class HrEducation
    {
        [Key]
        public int EducationId { get; set; }
        [StringLength(10)]
        public string? EducationCode { get; set; }
        [StringLength(10)]
        public string? EducationName1 { get; set; }
        [StringLength(10)]
        public string? EducationName2 { get; set; }
        [StringLength(10)]
        public string? EducationDesc { get; set; }
        [StringLength(10)]
        public string? Qualification { get; set; }
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
