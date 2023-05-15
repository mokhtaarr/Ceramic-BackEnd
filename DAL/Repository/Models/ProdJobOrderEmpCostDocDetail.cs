using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_JobOrderEmpCostDocDetail")]
    public partial class ProdJobOrderEmpCostDocDetail
    {
        [Key]
        [Column("JOrderEmpDocDetailId")]
        public int JorderEmpDocDetailId { get; set; }
        [Column("JOrderEmpDocId")]
        public int? JorderEmpDocId { get; set; }
        public int? EmpId { get; set; }
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

        [ForeignKey("JorderEmpDocId")]
        [InverseProperty("ProdJobOrderEmpCostDocDetails")]
        public virtual ProdJobOrderEmpCostDoc? JorderEmpDoc { get; set; }
    }
}
