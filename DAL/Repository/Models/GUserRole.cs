using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("G_UserRole")]
    public partial class GUserRole
    {
        public GUserRole()
        {
            GUserRolePermissions = new HashSet<GUserRolePermission>();
            GUsers = new HashSet<GUser>();
        }

        [Key]
        public int UserRoleId { get; set; }
        [StringLength(50)]
        public string? RoleCode { get; set; }
        [StringLength(100)]
        public string? RoleName1 { get; set; }
        [StringLength(100)]
        public string? RoleName2 { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
        [StringLength(100)]
        public string? AddField3 { get; set; }
        [StringLength(100)]
        public string? AddField4 { get; set; }
        [StringLength(100)]
        public string? AddField5 { get; set; }
        [StringLength(100)]
        public string? AddField6 { get; set; }
        [StringLength(100)]
        public string? AddField7 { get; set; }
        [StringLength(100)]
        public string? AddField8 { get; set; }
        [StringLength(100)]
        public string? AddField9 { get; set; }
        [StringLength(100)]
        public string? AddField10 { get; set; }
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

        [InverseProperty("UserRole")]
        public virtual ICollection<GUserRolePermission> GUserRolePermissions { get; set; }
        [InverseProperty("UserRole")]
        public virtual ICollection<GUser> GUsers { get; set; }
    }
}
