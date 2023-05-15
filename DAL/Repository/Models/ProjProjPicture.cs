using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjPicture")]
    [Index("Fsid", Name = "UQ__Proj_Pro__9C4B071785FAAD21", IsUnique = true)]
    public partial class ProjProjPicture
    {
        [Key]
        public int ProjPictureId { get; set; }
        [Column("FSId")]
        public Guid Fsid { get; set; }
        public int? ProjectId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Name2 { get; set; }
        [Unicode(false)]
        public string? AttachPath { get; set; }
        [Column("FData")]
        public byte[]? Fdata { get; set; }

        [ForeignKey("ProjectId")]
        [InverseProperty("ProjProjPictures")]
        public virtual ProjProject? Project { get; set; }
    }
}
