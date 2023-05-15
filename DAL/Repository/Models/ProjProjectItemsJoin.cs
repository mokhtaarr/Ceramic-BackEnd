using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjectItemsJoin")]
    public partial class ProjProjectItemsJoin
    {
        public ProjProjectItemsJoin()
        {
            ProjProjectItemEmpJoins = new HashSet<ProjProjectItemEmpJoin>();
        }

        [Key]
        public int ProjItemsJoinId { get; set; }
        public int? ProjectItemsId { get; set; }
        public int? ProjectId { get; set; }
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

        [ForeignKey("ProjectId")]
        [InverseProperty("ProjProjectItemsJoins")]
        public virtual ProjProject? Project { get; set; }
        [ForeignKey("ProjectItemsId")]
        [InverseProperty("ProjProjectItemsJoins")]
        public virtual ProjProjectItem? ProjectItems { get; set; }
        [InverseProperty("ProjItemsJoin")]
        public virtual ICollection<ProjProjectItemEmpJoin> ProjProjectItemEmpJoins { get; set; }
    }
}
