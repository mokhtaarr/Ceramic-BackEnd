using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_JobFiles")]
    public partial class SrJobFile
    {
        [Key]
        public int FileId { get; set; }
        public int? JorderId { get; set; }
        [StringLength(100)]
        public string? FileName { get; set; }
        [StringLength(250)]
        public string? FileDesc { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Image { get; set; }
        [Column("binary")]
        [MaxLength(4000)]
        public byte[]? Binary { get; set; }

        [ForeignKey("JorderId")]
        [InverseProperty("SrJobFiles")]
        public virtual SrJobOrder? Jorder { get; set; }
    }
}
