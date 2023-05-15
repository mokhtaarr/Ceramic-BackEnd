using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("An_AnimalWeightRateDetail")]
    public partial class AnAnimalWeightRateDetail
    {
        [Key]
        public int AnWeightRateDetailId { get; set; }
        public int? AnWeightRateId { get; set; }
        public int? AnTypeId { get; set; }
        public int? AnimalItemCardId { get; set; }
        public int? FoodItemCardId { get; set; }
        public int? FromAge { get; set; }
        public int? ToAge { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FromWeight { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ToWeight { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeightRateFrom { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeightRateTo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? MinWeightPrcnt { get; set; }

        [ForeignKey("AnWeightRateId")]
        [InverseProperty("AnAnimalWeightRateDetails")]
        public virtual AnAnimalWeightRate? AnWeightRate { get; set; }
    }
}
