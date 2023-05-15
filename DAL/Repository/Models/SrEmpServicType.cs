using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_EmpServicTypes")]
    public partial class SrEmpServicType
    {
        [Key]
        [Column("SR_ID")]
        public int SrId { get; set; }
        public int? EmpId { get; set; }
        [Column("SrTypID")]
        public int? SrTypId { get; set; }

        [ForeignKey("EmpId")]
        [InverseProperty("SrEmpServicTypes")]
        public virtual HrEmployee? Emp { get; set; }
        [ForeignKey("SrTypId")]
        [InverseProperty("SrEmpServicTypes")]
        public virtual SrServiceType? SrTyp { get; set; }
    }
}
