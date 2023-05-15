using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_Settings")]
    public partial class ProdSetting
    {
        [Key]
        public int ProdSettingId { get; set; }
        public int? BookId { get; set; }
        public int? FinishedProdValAccId { get; set; }
        public int? UndercostOperationAccId { get; set; }
        public int? DirectWorkersAccId { get; set; }
        public int? DirectServiceAccId { get; set; }
        public int? DirectEquipmentAccId { get; set; }
        public int? OtherCostsAccId { get; set; }
        public int? AccompanyproductsAccId { get; set; }
        public int? ScrapAccId { get; set; }
        public int? OutSourceCost { get; set; }
        public int? CostingAdjustmentId { get; set; }
        public byte? StandardCostPriority1 { get; set; }
        public byte? StandardCostPriority2 { get; set; }
        public byte? StandardCostPriority3 { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DailyWorkHours { get; set; }
        /// <summary>
        /// 1 production,2 Hr
        /// </summary>
        public bool? EmpDataSource { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MonthlyStandardWorkDays { get; set; }
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
    }
}
