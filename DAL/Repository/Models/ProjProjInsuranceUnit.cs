using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjInsuranceUnit")]
    public partial class ProjProjInsuranceUnit
    {
        [Key]
        public int ProjInsuranceUnitId { get; set; }
        public int? ProjUnitId { get; set; }
        public int? InsurCaseId { get; set; }
        public int? UnitInsurstatId { get; set; }
        public int? InsurCovTypeId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InsuranceValue { get; set; }

        [ForeignKey("InsurCaseId")]
        [InverseProperty("ProjProjInsuranceUnits")]
        public virtual CodInsuranceCase? InsurCase { get; set; }
        [ForeignKey("ProjUnitId")]
        [InverseProperty("ProjProjInsuranceUnits")]
        public virtual ProjProjUnit? ProjUnit { get; set; }
        [ForeignKey("UnitInsurstatId")]
        [InverseProperty("ProjProjInsuranceUnits")]
        public virtual CodUnitInsuranceStatus? UnitInsurstat { get; set; }
    }
}
