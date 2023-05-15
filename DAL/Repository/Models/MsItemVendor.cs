using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_ItemVendors")]
    public partial class MsItemVendor
    {
        [Key]
        public int ItemVendorId { get; set; }
        public int? ItemCardId { get; set; }
        public int? VendorId { get; set; }
        public bool? IsBasicVendor { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        [StringLength(10)]
        public string? Quantity1 { get; set; }
        [StringLength(10)]
        public string? Price1 { get; set; }
        [StringLength(10)]
        public string? Quantity2 { get; set; }
        [StringLength(10)]
        public string? Price2 { get; set; }
        [StringLength(10)]
        public string? Quantity3 { get; set; }
        [StringLength(10)]
        public string? Price3 { get; set; }
        [StringLength(10)]
        public string? Quantity4 { get; set; }
        [StringLength(10)]
        public string? Price4 { get; set; }
        [StringLength(10)]
        public string? Quantity5 { get; set; }
        [StringLength(10)]
        public string? Price5 { get; set; }
        [StringLength(10)]
        public string? Quantity6 { get; set; }
        [StringLength(10)]
        public string? Price6 { get; set; }
        [StringLength(10)]
        public string? Quantity7 { get; set; }
        [StringLength(10)]
        public string? Price7 { get; set; }
        [StringLength(10)]
        public string? Quantity8 { get; set; }
        [StringLength(10)]
        public string? Price8 { get; set; }
        [StringLength(10)]
        public string? Quantity9 { get; set; }
        [StringLength(10)]
        public string? Price9 { get; set; }
        [StringLength(10)]
        public string? Quantity10 { get; set; }
        [StringLength(10)]
        public string? Price10 { get; set; }

        [ForeignKey("ItemCardId")]
        [InverseProperty("MsItemVendors")]
        public virtual MsItemCard? ItemCard { get; set; }
        [ForeignKey("VendorId")]
        [InverseProperty("MsItemVendors")]
        public virtual MsVendor? Vendor { get; set; }
    }
}
