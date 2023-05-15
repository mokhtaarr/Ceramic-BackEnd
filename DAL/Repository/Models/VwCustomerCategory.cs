using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwCustomerCategory
    {
        [StringLength(50)]
        public string CustomerCode { get; set; } = null!;
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(100)]
        public string? CustomerDescE { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string? CatCode { get; set; }
        [StringLength(100)]
        public string? CatDescA { get; set; }
        [StringLength(100)]
        public string? CatDescE { get; set; }
    }
}
