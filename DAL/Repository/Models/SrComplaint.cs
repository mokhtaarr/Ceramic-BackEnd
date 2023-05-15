using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_Complaints")]
    public partial class SrComplaint
    {
        public SrComplaint()
        {
            SrReciptionDetails = new HashSet<SrReciptionDetail>();
            SrTasks = new HashSet<SrTask>();
        }

        [Key]
        [Column("ComID")]
        public int ComId { get; set; }
        [StringLength(50)]
        public string? ComCode { get; set; }
        [StringLength(100)]
        public string? ComName1 { get; set; }
        [StringLength(100)]
        public string? ComName2 { get; set; }
        [StringLength(1000)]
        public string? ComDesc { get; set; }
        [StringLength(1000)]
        public string? ComSolution { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        [StringLength(50)]
        public string? Add1 { get; set; }
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

        [InverseProperty("Com")]
        public virtual ICollection<SrReciptionDetail> SrReciptionDetails { get; set; }
        [InverseProperty("Com")]
        public virtual ICollection<SrTask> SrTasks { get; set; }
    }
}
