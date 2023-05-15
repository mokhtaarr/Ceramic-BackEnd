using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjectItems")]
    public partial class ProjProjectItem
    {
        public ProjProjectItem()
        {
            ProjProjectItemsJoins = new HashSet<ProjProjectItemsJoin>();
            ProjProjectItemsVendors = new HashSet<ProjProjectItemsVendor>();
        }

        [Key]
        public int ProjectItemsId { get; set; }
        public int Code { get; set; }
        [StringLength(100)]
        public string? DescA { get; set; }
        [StringLength(100)]
        public string? DescE { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        [StringLength(255)]
        public string? RemarksA { get; set; }
        [StringLength(255)]
        public string? RemarksE { get; set; }

        [InverseProperty("ProjectItems")]
        public virtual ICollection<ProjProjectItemsJoin> ProjProjectItemsJoins { get; set; }
        [InverseProperty("ProjectItems")]
        public virtual ICollection<ProjProjectItemsVendor> ProjProjectItemsVendors { get; set; }
    }
}
