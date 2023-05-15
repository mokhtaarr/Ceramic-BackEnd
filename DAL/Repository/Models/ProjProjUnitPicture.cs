using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjUnitPicture")]
    [Index("Fsid", Name = "UQ__Proj_Pro__9C4B07174432347E", IsUnique = true)]
    public partial class ProjProjUnitPicture
    {
        [Key]
        public int ProjUnitPictureId { get; set; }
        [Column("FSId")]
        public Guid Fsid { get; set; }
        public int? ProjUnitId { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public string? AttachPath { get; set; }
        [Column("FData")]
        public byte[]? Fdata { get; set; }

        [ForeignKey("ProjUnitId")]
        [InverseProperty("ProjProjUnitPictures")]
        public virtual ProjProjUnit? ProjUnit { get; set; }
    }
}
