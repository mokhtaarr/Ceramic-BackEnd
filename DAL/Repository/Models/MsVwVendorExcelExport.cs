using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class MsVwVendorExcelExport
    {
        [StringLength(50)]
        public string VendorCode { get; set; } = null!;
        [StringLength(100)]
        public string? VendorDescA { get; set; }
        [StringLength(100)]
        public string? VendorDescE { get; set; }
        public bool? IsActive { get; set; }
        public int? CreditPeriod { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditLimit { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(20)]
        public string? Fax { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(100)]
        public string? Address { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(20)]
        public string CurrencyCode { get; set; } = null!;
        [StringLength(20)]
        public string? CurrencyDescA { get; set; }
        [StringLength(50)]
        public string? CatCode { get; set; }
        [StringLength(100)]
        public string? CatDescA { get; set; }
    }
}
