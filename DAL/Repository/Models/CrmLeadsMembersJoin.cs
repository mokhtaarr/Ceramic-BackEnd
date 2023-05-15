using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("CRM_LeadsMembersJoin")]
    public partial class CrmLeadsMembersJoin
    {
        [Key]
        public int LeadMemberJoin { get; set; }
        public int? LeadMemberId { get; set; }
        public int? LeadId { get; set; }

        [ForeignKey("LeadId")]
        [InverseProperty("CrmLeadsMembersJoins")]
        public virtual CrmLead? Lead { get; set; }
        [ForeignKey("LeadMemberId")]
        [InverseProperty("CrmLeadsMembersJoins")]
        public virtual CrmLeadsMember? LeadMember { get; set; }
    }
}
