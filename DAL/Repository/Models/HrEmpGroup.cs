using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_EmpGroups")]
    public partial class HrEmpGroup
    {
        public HrEmpGroup()
        {
            HrEmployees = new HashSet<HrEmployee>();
            InverseParent = new HashSet<HrEmpGroup>();
        }

        [Key]
        [Column("HREmpGroupId")]
        public int HrempGroupId { get; set; }
        [StringLength(50)]
        public string? GroupCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public int? ParentId { get; set; }
        public byte? GroupType { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("ParentId")]
        [InverseProperty("InverseParent")]
        public virtual HrEmpGroup? Parent { get; set; }
        [InverseProperty("HrempGroup")]
        public virtual ICollection<HrEmployee> HrEmployees { get; set; }
        [InverseProperty("Parent")]
        public virtual ICollection<HrEmpGroup> InverseParent { get; set; }
    }
}
