using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_EmpMovePromotDetail")]
    public partial class HrEmpMovePromotDetail
    {
        [Key]
        public int EmpMoveDetailId { get; set; }
        public int? EmpMoveId { get; set; }
        public int? EmpId { get; set; }
        public int? SalaryTypId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OldSalaryValu { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SalaryValu { get; set; }

        [ForeignKey("EmpMoveId")]
        [InverseProperty("HrEmpMovePromotDetails")]
        public virtual HrEmpMovePromotion? EmpMove { get; set; }
    }
}
