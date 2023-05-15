using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_VendorUsers")]
    public partial class MsVendorUser
    {
        [Key]
        public int VendUserId { get; set; }
        public int? VendorId { get; set; }
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

        [ForeignKey("UserId")]
        [InverseProperty("MsVendorUsers")]
        public virtual GUser? User { get; set; }
        [ForeignKey("VendorId")]
        [InverseProperty("MsVendorUsers")]
        public virtual MsVendor? Vendor { get; set; }
    }
}
