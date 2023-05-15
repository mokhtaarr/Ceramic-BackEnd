using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("CRM_LeadsMembersDetails")]
    public partial class CrmLeadsMembersDetail
    {
        [Key]
        public int LeadMemberDetailId { get; set; }
        public int? LeadMemberId { get; set; }
        public int? LeadId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ToDate { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }

        [ForeignKey("LeadMemberId")]
        [InverseProperty("CrmLeadsMembersDetails")]
        public virtual CrmLeadsMember? LeadMember { get; set; }
    }
}
