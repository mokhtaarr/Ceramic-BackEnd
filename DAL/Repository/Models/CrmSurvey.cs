using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("CRM_Survey")]
    public partial class CrmSurvey
    {
        [Key]
        public int SurveyId { get; set; }
        public int VisitTypeId { get; set; }
        public int? UserRoleId { get; set; }
        [StringLength(50)]
        public string VisitCode { get; set; } = null!;
        [StringLength(100)]
        public string? VisitName1 { get; set; }
        [StringLength(100)]
        public string? VisitName2 { get; set; }
        public byte? AnswerType { get; set; }
        [StringLength(255)]
        public string? AddField1 { get; set; }
        [StringLength(255)]
        public string? AddField2 { get; set; }
        [StringLength(255)]
        public string? AddField3 { get; set; }
        [StringLength(255)]
        public string? AddField4 { get; set; }
        [StringLength(255)]
        public string? AddField5 { get; set; }
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

        [ForeignKey("VisitTypeId")]
        [InverseProperty("CrmSurveys")]
        public virtual CrmVisitType VisitType { get; set; } = null!;
    }
}
