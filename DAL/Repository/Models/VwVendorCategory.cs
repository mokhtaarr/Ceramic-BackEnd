using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwVendorCategory
    {
        [StringLength(50)]
        public string VendorCode { get; set; } = null!;
        [StringLength(100)]
        public string? VendorDescA { get; set; }
        [StringLength(100)]
        public string? VendorDescE { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsBlocked { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(100)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string? CatCode { get; set; }
        [StringLength(100)]
        public string? CatDescA { get; set; }
        [StringLength(100)]
        public string? CatDescE { get; set; }
    }
}
