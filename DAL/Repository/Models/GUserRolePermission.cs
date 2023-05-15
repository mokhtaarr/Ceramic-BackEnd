using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("G_UserRolePermissions")]
    public partial class GUserRolePermission
    {
        [Key]
        public int UserRolePermId { get; set; }
        public int? UserRoleId { get; set; }
        [StringLength(100)]
        public string ModuleCode { get; set; } = null!;
        [StringLength(100)]
        public string? ModuleDescA { get; set; }
        /// <summary>
        /// 1 screen, 2 TabPage,3 Label
        /// </summary>
        public byte? ModuleType { get; set; }
        public bool CanOpen { get; set; }
        public bool CanCreate { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanPrint { get; set; }
        public bool CanPreView { get; set; }
        public bool CanPost { get; set; }

        [ForeignKey("UserRoleId")]
        [InverseProperty("GUserRolePermissions")]
        public virtual GUserRole? UserRole { get; set; }
    }
}
