using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ItemCardVendors")]
    public partial class MsItemCardVendor
    {
        [Key]
        public int ItemVendorId { get; set; }
        public int? ItemCardId { get; set; }
        public int? VendorId { get; set; }
    }
}
