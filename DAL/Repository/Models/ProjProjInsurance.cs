using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjInsurance")]
    public partial class ProjProjInsurance
    {
        [Key]
        public int ProjInsuranceId { get; set; }
        public int? ProjectId { get; set; }
        public int? BuildInsurStatId { get; set; }
        public int? InsurCovTypeId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InsuranceValue { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("BuildInsurStatId")]
        [InverseProperty("ProjProjInsurances")]
        public virtual CodBuildingInsuranceStatus? BuildInsurStat { get; set; }
        [ForeignKey("ProjectId")]
        [InverseProperty("ProjProjInsurances")]
        public virtual ProjProject? Project { get; set; }
    }
}
