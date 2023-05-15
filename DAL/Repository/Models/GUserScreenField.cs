using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("G_UserScreenFields")]
    public partial class GUserScreenField
    {
        [Key]
        public int ScreenFieldId { get; set; }
        public int? UserModuleId { get; set; }
        public int? UserId { get; set; }
        public int? UserGroupId { get; set; }
        [StringLength(50)]
        public string? FieldName { get; set; }
        [StringLength(100)]
        public string? AuthDesc { get; set; }
        public bool? Authinticated { get; set; }
        public int? AuthenticatedBy { get; set; }
    }
}
