using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_BoxUsers")]
    public partial class MsBoxUser
    {
        [Key]
        public int BoxUsersId { get; set; }
        public int? BoxId { get; set; }
        public int? UserId { get; set; }
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

        [ForeignKey("BoxId")]
        [InverseProperty("MsBoxUsers")]
        public virtual MsBoxBank? Box { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("MsBoxUsers")]
        public virtual GUser? User { get; set; }
    }
}
