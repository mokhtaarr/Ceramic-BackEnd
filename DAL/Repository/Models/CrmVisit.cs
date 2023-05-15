using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("CRM_Visits")]
    public partial class CrmVisit
    {
        public CrmVisit()
        {
            CrmVisitSurveys = new HashSet<CrmVisitSurvey>();
        }

        [Key]
        public int VisitId { get; set; }
        public int? VisitTypeId { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? TeamMemberId { get; set; }
        public int? LeadId { get; set; }
        public bool? LeadGetBounus { get; set; }
        [StringLength(100)]
        public string? BounusDesc { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
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
        [InverseProperty("CrmVisits")]
        public virtual CrmVisitType? VisitType { get; set; }
        [InverseProperty("Visit")]
        public virtual ICollection<CrmVisitSurvey> CrmVisitSurveys { get; set; }
    }
}
