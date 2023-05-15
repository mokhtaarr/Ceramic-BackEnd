using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjItemEmpTaskJoin")]
    public partial class ProjProjItemEmpTaskJoin
    {
        [Key]
        public int ProjItemEmpTaskId { get; set; }
        public int? ProjItemEmpId { get; set; }
        public int? TaskId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpectItemPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpectItemValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ActualItemPercentExpense { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ActualItemExpenseValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FinishPercent { get; set; }
        [StringLength(500)]
        public string? Remarks1 { get; set; }
        [StringLength(500)]
        public string? Remarks2 { get; set; }

        [ForeignKey("ProjItemEmpId")]
        [InverseProperty("ProjProjItemEmpTaskJoins")]
        public virtual ProjProjectItemEmpJoin? ProjItemEmp { get; set; }
        [ForeignKey("TaskId")]
        [InverseProperty("ProjProjItemEmpTaskJoins")]
        public virtual ProdTask? Task { get; set; }
    }
}
