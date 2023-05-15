using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_ItemImages")]
    public partial class MsItemImage
    {
        [Key]
        public int ImgId { get; set; }
        public int? ItemCardId { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Image { get; set; }
        [StringLength(250)]
        public string? ImgDesc1 { get; set; }
        [StringLength(250)]
        public string? ImgDesc2 { get; set; }
        [StringLength(500)]
        public string? ImgPath { get; set; }

        [ForeignKey("ItemCardId")]
        [InverseProperty("MsItemImages")]
        public virtual MsItemCard? ItemCard { get; set; }
    }
}
