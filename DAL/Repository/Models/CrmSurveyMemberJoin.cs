using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("CRM_SurveyMemberJoin")]
    public partial class CrmSurveyMemberJoin
    {
        [Key]
        public int SurveyVisitId { get; set; }
        public int? SurveyId { get; set; }
        public int? TeamMemberId { get; set; }
    }
}
