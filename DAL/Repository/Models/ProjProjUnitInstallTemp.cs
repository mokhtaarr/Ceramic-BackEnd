using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjUnitInstallTemp")]
    public partial class ProjProjUnitInstallTemp
    {
        [Key]
        public int ProjUnitInstallTempId { get; set; }
        public int? ProjUnitId { get; set; }
        public int? InstallTempId { get; set; }

        [ForeignKey("InstallTempId")]
        [InverseProperty("ProjProjUnitInstallTemps")]
        public virtual CodInstallmentTemp? InstallTemp { get; set; }
        [ForeignKey("ProjUnitId")]
        [InverseProperty("ProjProjUnitInstallTemps")]
        public virtual ProjProjUnit? ProjUnit { get; set; }
    }
}
