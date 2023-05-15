using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_LotNumberExpiry")]
    public partial class MsLotNumberExpiry
    {
        [Key]
        public int LotNumberExpiryId { get; set; }
        public int? LotNumberConfigId { get; set; }
        [StringLength(50)]
        public string? LotNumberExpiry { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ProdDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpiryDate { get; set; }
        public int? Period { get; set; }
        /// <summary>
        /// 1 day, 2 month, 3 year
        /// </summary>
        public byte? PeriodType { get; set; }
        [StringLength(100)]
        public string? Remark { get; set; }
        public bool? Disabled { get; set; }
        [StringLength(50)]
        public string? FixedPart { get; set; }
        [StringLength(50)]
        public string? ManualPart { get; set; }
        [StringLength(50)]
        public string? ManualPart2 { get; set; }
        [StringLength(50)]
        public string? ManualPart3 { get; set; }
        [StringLength(50)]
        public string? ManualPart4 { get; set; }
        [StringLength(50)]
        public string? ManualPart5 { get; set; }
        [StringLength(50)]
        public string? ManualPart6 { get; set; }
        [StringLength(10)]
        public string? Day { get; set; }
        [StringLength(10)]
        public string? Week { get; set; }
        [StringLength(10)]
        public string? Month { get; set; }
        [StringLength(10)]
        public string? Year { get; set; }
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
        [StringLength(100)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(100)]
        public string? Remarks3 { get; set; }
        [StringLength(100)]
        public string? Remarks4 { get; set; }
        [StringLength(100)]
        public string? Remarks5 { get; set; }
        [StringLength(100)]
        public string? Remarks6 { get; set; }
        [StringLength(100)]
        public string? Remarks7 { get; set; }
    }
}
