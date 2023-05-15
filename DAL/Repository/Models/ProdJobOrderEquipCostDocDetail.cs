using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_JobOrderEquipCostDocDetail")]
    public partial class ProdJobOrderEquipCostDocDetail
    {
        [Key]
        [Column("JOrderEquipDocDetailId")]
        public int JorderEquipDocDetailId { get; set; }
        [Column("JOrderEquipDocId")]
        public int? JorderEquipDocId { get; set; }
        public int? EquipId { get; set; }
        public int? TaskId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FromTime { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ToTime { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExecutTime { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CostHour { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCost { get; set; }

        [ForeignKey("JorderEquipDocId")]
        [InverseProperty("ProdJobOrderEquipCostDocDetails")]
        public virtual ProdJobOrderEquipCostDoc? JorderEquipDoc { get; set; }
    }
}
