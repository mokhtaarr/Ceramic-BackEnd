using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("CRM_TeamMembers")]
    public partial class CrmTeamMember
    {
        [Key]
        public int TeamMemberId { get; set; }
        public int? TeamId { get; set; }
        public int? StoreId { get; set; }
        public int? EmpId { get; set; }
        [StringLength(50)]
        public string MemberCode { get; set; } = null!;
        [StringLength(100)]
        public string? MemberName1 { get; set; }
        [StringLength(100)]
        public string? MemberName2 { get; set; }
        public bool? IsTeamLeader { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? DefaultTarget { get; set; }
        public bool? IsActive { get; set; }
        public int? CityId { get; set; }
        public int? RegionId { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
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

        [ForeignKey("TeamId")]
        [InverseProperty("CrmTeamMembers")]
        public virtual CrmTeam? Team { get; set; }
    }
}
