using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("CRM_LeadsMembers")]
    public partial class CrmLeadsMember
    {
        public CrmLeadsMember()
        {
            CrmLeadsMembersDetails = new HashSet<CrmLeadsMembersDetail>();
            CrmLeadsMembersJoins = new HashSet<CrmLeadsMembersJoin>();
        }

        [Key]
        public int LeadMemberId { get; set; }
        public int? StoreId { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? TeamMemberId { get; set; }
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

        [InverseProperty("LeadMember")]
        public virtual ICollection<CrmLeadsMembersDetail> CrmLeadsMembersDetails { get; set; }
        [InverseProperty("LeadMember")]
        public virtual ICollection<CrmLeadsMembersJoin> CrmLeadsMembersJoins { get; set; }
    }
}
