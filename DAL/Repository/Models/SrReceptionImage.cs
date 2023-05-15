using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_ReceptionImages")]
    public partial class SrReceptionImage
    {
        [Key]
        public int RecImgId { get; set; }
        public int? ReciptionId { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Image { get; set; }
        [StringLength(250)]
        public string? ImgDesc { get; set; }

        [ForeignKey("ReciptionId")]
        [InverseProperty("SrReceptionImages")]
        public virtual SrReciption? Reciption { get; set; }
    }
}
