using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_Tasks")]
    public partial class ProdTask
    {
        public ProdTask()
        {
            ProdJoinTaskEquipments = new HashSet<ProdJoinTaskEquipment>();
            ProdJoinTaskJobs = new HashSet<ProdJoinTaskJob>();
            ProjProjItemEmpTaskJoins = new HashSet<ProjProjItemEmpTaskJoin>();
        }

        [Key]
        public int TaskId { get; set; }
        [StringLength(50)]
        public string? TaskCode { get; set; }
        [StringLength(100)]
        public string? TaskName1 { get; set; }
        [StringLength(100)]
        public string? TaskName2 { get; set; }
        [StringLength(500)]
        public string? TaskDesc { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        [StringLength(500)]
        public string? Comment { get; set; }
        public int? PurOrderId { get; set; }
        public byte? OperationType { get; set; }
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

        [InverseProperty("Task")]
        public virtual ICollection<ProdJoinTaskEquipment> ProdJoinTaskEquipments { get; set; }
        [InverseProperty("Task")]
        public virtual ICollection<ProdJoinTaskJob> ProdJoinTaskJobs { get; set; }
        [InverseProperty("Task")]
        public virtual ICollection<ProjProjItemEmpTaskJoin> ProjProjItemEmpTaskJoins { get; set; }
    }
}
