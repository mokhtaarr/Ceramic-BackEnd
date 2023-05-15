using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjectItemEmpJoin")]
    public partial class ProjProjectItemEmpJoin
    {
        public ProjProjectItemEmpJoin()
        {
            ProjProjItemEmpTaskJoins = new HashSet<ProjProjItemEmpTaskJoin>();
        }

        [Key]
        public int ProjItemEmpId { get; set; }
        public int? ProjItemsJoinId { get; set; }
        public int? EmpId { get; set; }

        [ForeignKey("EmpId")]
        [InverseProperty("ProjProjectItemEmpJoins")]
        public virtual HrEmployee? Emp { get; set; }
        [ForeignKey("ProjItemsJoinId")]
        [InverseProperty("ProjProjectItemEmpJoins")]
        public virtual ProjProjectItemsJoin? ProjItemsJoin { get; set; }
        [InverseProperty("ProjItemEmp")]
        public virtual ICollection<ProjProjItemEmpTaskJoin> ProjProjItemEmpTaskJoins { get; set; }
    }
}
