using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_EquipProfile")]
    public partial class ProdEquipProfile
    {
        [Key]
        public int EquipProfileId { get; set; }
        [StringLength(50)]
        public string? ProfileCode { get; set; }
        public int? EquipId { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(500)]
        public string? ProdileDesc { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("EquipId")]
        [InverseProperty("ProdEquipProfiles")]
        public virtual ProdEquipment? Equip { get; set; }
    }
}
