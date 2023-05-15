using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjectItemsVendors")]
    public partial class ProjProjectItemsVendor
    {
        [Key]
        public int ProjectItemsVendorId { get; set; }
        public int? ProjectItemsId { get; set; }
        public int? VendorId { get; set; }
        public byte? VendorRate { get; set; }

        [ForeignKey("ProjectItemsId")]
        [InverseProperty("ProjProjectItemsVendors")]
        public virtual ProjProjectItem? ProjectItems { get; set; }
        [ForeignKey("VendorId")]
        [InverseProperty("ProjProjectItemsVendors")]
        public virtual MsVendor? Vendor { get; set; }
    }
}
