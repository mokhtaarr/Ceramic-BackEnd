using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cod_InstallmentTemps")]
    public partial class CodInstallmentTemp
    {
        public CodInstallmentTemp()
        {
            CodInstallmentTempsDetails = new HashSet<CodInstallmentTempsDetail>();
            ProjProjUnitInstallTemps = new HashSet<ProjProjUnitInstallTemp>();
        }

        [Key]
        public int InstallTempId { get; set; }
        public int Code { get; set; }
        [StringLength(100)]
        public string? DescA { get; set; }
        [StringLength(100)]
        public string? DescE { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public bool? IsPercent { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? YearsCount { get; set; }
        public bool? CanEditInstallManual { get; set; }
        public bool? IsRental { get; set; }
        public bool? AutoRenew { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AddValue { get; set; }
        public int? EveryPayCount { get; set; }
        public int? AfterPeriod { get; set; }
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

        [InverseProperty("InstallTemp")]
        public virtual ICollection<CodInstallmentTempsDetail> CodInstallmentTempsDetails { get; set; }
        [InverseProperty("InstallTemp")]
        public virtual ICollection<ProjProjUnitInstallTemp> ProjProjUnitInstallTemps { get; set; }
    }
}
