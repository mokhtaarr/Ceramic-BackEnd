using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MsGA_LetterFayumDetail")]
    public partial class MsGaLetterFayumDetail
    {
        [Key]
        public int LetFayumDetailId { get; set; }
        public int? LetterFayumId { get; set; }
        [StringLength(100)]
        public string? BuyerName { get; set; }
        [StringLength(200)]
        public string? BuyerAddress { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AddDate { get; set; }
        [StringLength(50)]
        public string? BuyerId { get; set; }
        public bool? IsCurrentBuyer { get; set; }
        [Column("colSalePrinted")]
        public bool? ColSalePrinted { get; set; }
        [Column("colQutPrinted")]
        public bool? ColQutPrinted { get; set; }
        [Column("colLetterPrinted")]
        public bool? ColLetterPrinted { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Image { get; set; }
        [StringLength(50)]
        public string? UserName { get; set; }
        [StringLength(50)]
        public string? FirstName { get; set; }
        public int? UserId { get; set; }
        [StringLength(200)]
        public string? AddField1 { get; set; }
        [StringLength(200)]
        public string? AddField2 { get; set; }
        [StringLength(100)]
        public string? AddField11 { get; set; }
        [StringLength(100)]
        public string? AddField21 { get; set; }

        [ForeignKey("LetterFayumId")]
        [InverseProperty("MsGaLetterFayumDetails")]
        public virtual MsGaLetterFayum? LetterFayum { get; set; }
    }
}
