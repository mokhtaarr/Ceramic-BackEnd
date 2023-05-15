using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("An_Medicin")]
    public partial class AnMedicin
    {
        public AnMedicin()
        {
            AnAnimalMidicins = new HashSet<AnAnimalMidicin>();
        }

        [Key]
        public int AnMidicinId { get; set; }
        public int Code { get; set; }
        [StringLength(100)]
        public string? DescA { get; set; }
        [StringLength(100)]
        public string? DescE { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public byte? Shots { get; set; }
        /// <summary>
        /// Days
        /// </summary>
        public int? AnimalAge { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Weight { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        [StringLength(255)]
        public string? RemarksA { get; set; }
        [StringLength(255)]
        public string? RemarksE { get; set; }

        [InverseProperty("AnMidicin")]
        public virtual ICollection<AnAnimalMidicin> AnAnimalMidicins { get; set; }
    }
}
