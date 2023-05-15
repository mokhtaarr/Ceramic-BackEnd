using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("G_UserGroups")]
    public partial class GUserGroup
    {
        [Key]
        public int UserGroupId { get; set; }
        [StringLength(50)]
        public string? UserGroupCode { get; set; }
        [StringLength(100)]
        public string? UserGroupName1 { get; set; }
        [StringLength(100)]
        public string? UserGroupName2 { get; set; }
        public int? ParentUserGroupId { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
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
    }
}
