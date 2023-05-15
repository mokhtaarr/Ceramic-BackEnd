using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_ProductionLineDetails")]
    public partial class ProdProductionLineDetail
    {
        [Key]
        public int ProdLineDetailId { get; set; }
        public int? ProLineId { get; set; }
        public int? TaskId { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? TimeBeforFormat { get; set; }
        /// <summary>
        /// 1 Minutes, 2 Hours,3 Days, 4 Months
        /// </summary>
        public byte? TimeUnit { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Minutes { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Hours { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Days { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Months { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }

        [ForeignKey("ProLineId")]
        [InverseProperty("ProdProductionLineDetails")]
        public virtual ProdProductionLine? ProLine { get; set; }
    }
}
