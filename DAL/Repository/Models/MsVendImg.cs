using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_VendImgs")]
    public partial class MsVendImg
    {
        [Key]
        public int VendImgId { get; set; }
        public int? VendorId { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Image { get; set; }
        [StringLength(250)]
        public string? ImgDesc1 { get; set; }
        [StringLength(250)]
        public string? ImgDesc2 { get; set; }

        [ForeignKey("VendorId")]
        [InverseProperty("MsVendImgs")]
        public virtual MsVendor? Vendor { get; set; }
    }
}
