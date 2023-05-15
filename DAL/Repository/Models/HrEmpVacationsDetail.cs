using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_EmpVacationsDetails")]
    public partial class HrEmpVacationsDetail
    {
        [Key]
        public int EmpVacDetailId { get; set; }
        public int? EmpVacId { get; set; }
        public int? EmpId { get; set; }
        public byte? OldAnnualVacs { get; set; }
        public byte? OldReservedVacs { get; set; }
        public byte? OldAnnualBalance { get; set; }
        public byte? OldReservedVacsBalance { get; set; }
        public byte? AnnualVacs { get; set; }
        public byte? ReservedVacs { get; set; }
        public byte? AnnualBalance { get; set; }
        public byte? ReservedVacsBalance { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }

        [ForeignKey("EmpVacId")]
        [InverseProperty("HrEmpVacationsDetails")]
        public virtual HrEmpVacation? EmpVac { get; set; }
    }
}
