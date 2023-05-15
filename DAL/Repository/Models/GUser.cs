using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("G_Users")]
    public partial class GUser
    {
        public GUser()
        {
            CalAccountUsers = new HashSet<CalAccountUser>();
            GUserModules = new HashSet<GUserModule>();
            MsBoxUsers = new HashSet<MsBoxUser>();
            MsCusromerUsers = new HashSet<MsCusromerUser>();
            MsVendorUsers = new HashSet<MsVendorUser>();
        }

        [Key]
        public int UserId { get; set; }
        public int? EmpId { get; set; }
        public int? UserGroupId { get; set; }
        public int? UserRoleId { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(50)]
        public string? UserCode { get; set; }
        public int? StoreId { get; set; }
        [StringLength(50)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        public string? LastName { get; set; }
        [StringLength(50)]
        public string? UserName { get; set; }
        [StringLength(50)]
        public string? Password { get; set; }
        /// <summary>
        /// 0 User , 1 superUser , 2 admin
        /// </summary>
        public byte? UserType { get; set; }
        [StringLength(20)]
        public string? Custom1 { get; set; }
        [StringLength(20)]
        public string? Custom2 { get; set; }
        [StringLength(20)]
        public string? Custom3 { get; set; }
        [StringLength(20)]
        public string? Custom4 { get; set; }
        [StringLength(20)]
        public string? Custom5 { get; set; }
        public int? ShiftId { get; set; }
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

        [ForeignKey("UserRoleId")]
        [InverseProperty("GUsers")]
        public virtual GUserRole? UserRole { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<CalAccountUser> CalAccountUsers { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<GUserModule> GUserModules { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<MsBoxUser> MsBoxUsers { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<MsCusromerUser> MsCusromerUsers { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<MsVendorUser> MsVendorUsers { get; set; }
    }
}
