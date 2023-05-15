using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_VendorBranches")]
    public partial class MsVendorBranch
    {
        [Key]
        public int VendBranchId { get; set; }
        public int? VendorId { get; set; }
        [StringLength(50)]
        public string? VendBranchCode { get; set; }
        [StringLength(100)]
        public string? VendBranchName1 { get; set; }
        [StringLength(100)]
        public string? VendBranchName2 { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        [StringLength(250)]
        public string? Address { get; set; }

        [ForeignKey("VendorId")]
        [InverseProperty("MsVendorBranches")]
        public virtual MsVendor? Vendor { get; set; }
    }
}
