using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("CRM_VisitSurveys")]
    public partial class CrmVisitSurvey
    {
        [Key]
        public int VisitSurveyId { get; set; }
        public int? VisitId { get; set; }
        public int? SurveyId { get; set; }
        [StringLength(200)]
        public string? Answer1 { get; set; }
        [StringLength(200)]
        public string? Answer2 { get; set; }
        [StringLength(200)]
        public string? Answer3 { get; set; }
        [StringLength(200)]
        public string? Answer4 { get; set; }
        public bool? AnswerYorN { get; set; }
        [StringLength(500)]
        public string? FilePath { get; set; }

        [ForeignKey("VisitId")]
        [InverseProperty("CrmVisitSurveys")]
        public virtual CrmVisit? Visit { get; set; }
    }
}
