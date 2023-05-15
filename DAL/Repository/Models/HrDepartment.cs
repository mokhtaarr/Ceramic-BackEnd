using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_Departments")]
    public partial class HrDepartment
    {
        public HrDepartment()
        {
            HrEmployees = new HashSet<HrEmployee>();
            InverseParent = new HashSet<HrDepartment>();
        }

        [Key]
        public int DepartMentId { get; set; }
        [StringLength(50)]
        public string? DepartCode { get; set; }
        [StringLength(100)]
        public string? DepartName1 { get; set; }
        [StringLength(100)]
        public string? DepartName2 { get; set; }
        [StringLength(500)]
        public string? DepartTask { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        public int? ParentId { get; set; }
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
        public virtual HrDepartment? Parent { get; set; }
        [InverseProperty("DepartMent")]
        public virtual ICollection<HrEmployee> HrEmployees { get; set; }
        [InverseProperty("Parent")]
        public virtual ICollection<HrDepartment> InverseParent { get; set; }
    }
}
