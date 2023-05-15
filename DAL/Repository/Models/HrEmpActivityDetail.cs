using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_EmpActivityDetail")]
    public partial class HrEmpActivityDetail
    {
        public HrEmpActivityDetail()
        {
            HrActivityDetailElements = new HashSet<HrActivityDetailElement>();
        }

        [Key]
        public int EmpActivityDetailId { get; set; }
        public int? EmpActivityId { get; set; }
        public int? EmpId { get; set; }

        [ForeignKey("EmpActivityId")]
        [InverseProperty("HrEmpActivityDetails")]
        public virtual HrEmpActivity? EmpActivity { get; set; }
        [InverseProperty("EmpActivityDetail")]
        public virtual ICollection<HrActivityDetailElement> HrActivityDetailElements { get; set; }
    }
}
