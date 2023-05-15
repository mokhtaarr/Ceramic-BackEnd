using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_CustImgs")]
    public partial class MsCustImg
    {
        [Key]
        public int CustImgId { get; set; }
        public int? CustomerId { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Image { get; set; }
        [StringLength(250)]
        public string? ImgDesc1 { get; set; }
        [StringLength(250)]
        public string? ImgDesc2 { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("MsCustImgs")]
        public virtual MsCustomer? Customer { get; set; }
    }
}
