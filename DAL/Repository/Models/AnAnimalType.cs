using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("An_AnimalType")]
    public partial class AnAnimalType
    {
        public AnAnimalType()
        {
            AnAnimalMidicins = new HashSet<AnAnimalMidicin>();
        }

        [Key]
        public int AnTypeId { get; set; }
        [StringLength(50)]
        public string Code { get; set; } = null!;
        [StringLength(100)]
        public string? DescA { get; set; }
        [StringLength(100)]
        public string? DescE { get; set; }
        public int? ParentAnTypeId { get; set; }
        public byte? AnTypeType { get; set; }
        public int? AnTypeLevel { get; set; }
        [Column(TypeName = "image")]
        public byte[]? AnTypeImage { get; set; }
        public int? CurrentTrNo { get; set; }
        [StringLength(100)]
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }

        [InverseProperty("AnType")]
        public virtual ICollection<AnAnimalMidicin> AnAnimalMidicins { get; set; }
    }
}
