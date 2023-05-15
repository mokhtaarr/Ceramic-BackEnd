using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("An_ANimalMidicin")]
    public partial class AnAnimalMidicin
    {
        [Key]
        public int AnAnimalMidicinId { get; set; }
        public int AnMidicinId { get; set; }
        public int? AnTypeId { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? NextNotify { get; set; }

        [ForeignKey("AnMidicinId")]
        [InverseProperty("AnAnimalMidicins")]
        public virtual AnMedicin AnMidicin { get; set; } = null!;
        [ForeignKey("AnTypeId")]
        [InverseProperty("AnAnimalMidicins")]
        public virtual AnAnimalType? AnType { get; set; }
    }
}
