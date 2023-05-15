using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_Tasks")]
    public partial class SrTask
    {
        public SrTask()
        {
            SrTaskEmps = new HashSet<SrTaskEmp>();
            SrTaskItems = new HashSet<SrTaskItem>();
        }

        [Key]
        public int TaskId { get; set; }
        [Column("ComID")]
        public int? ComId { get; set; }
        [StringLength(50)]
        public string? TaskCode { get; set; }
        [StringLength(100)]
        public string? TaskName1 { get; set; }
        [StringLength(100)]
        public string? TaskName2 { get; set; }
        [StringLength(500)]
        public string? TaskDescription { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Duration { get; set; }
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

        [ForeignKey("ComId")]
        [InverseProperty("SrTasks")]
        public virtual SrComplaint? Com { get; set; }
        [InverseProperty("Task")]
        public virtual ICollection<SrTaskEmp> SrTaskEmps { get; set; }
        [InverseProperty("Task")]
        public virtual ICollection<SrTaskItem> SrTaskItems { get; set; }
    }
}
