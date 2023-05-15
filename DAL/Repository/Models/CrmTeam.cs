using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("CRM_Teams")]
    public partial class CrmTeam
    {
        public CrmTeam()
        {
            CrmTeamMembers = new HashSet<CrmTeamMember>();
        }

        [Key]
        public int TeamId { get; set; }
        [StringLength(50)]
        public string TeamCode { get; set; } = null!;
        [StringLength(100)]
        public string? TeamName1 { get; set; }
        [StringLength(100)]
        public string? TeamName2 { get; set; }
        public int? StoreId { get; set; }
        public int? Capacaty { get; set; }
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

        [InverseProperty("Team")]
        public virtual ICollection<CrmTeamMember> CrmTeamMembers { get; set; }
    }
}
