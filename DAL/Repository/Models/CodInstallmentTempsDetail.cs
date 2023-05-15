using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cod_InstallmentTempsDetail")]
    public partial class CodInstallmentTempsDetail
    {
        [Key]
        public int InstallTempDetailId { get; set; }
        public int? InstallTempId { get; set; }
        public int? PayTypeId { get; set; }
        public int? PayCount { get; set; }
        public int? PayRepeat { get; set; }
        public int? YearOrder { get; set; }
        public int? MonthOrder { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PayValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PayPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalValue { get; set; }
        public int? MonthOfInstall { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("InstallTempId")]
        [InverseProperty("CodInstallmentTempsDetails")]
        public virtual CodInstallmentTemp? InstallTemp { get; set; }
    }
}
