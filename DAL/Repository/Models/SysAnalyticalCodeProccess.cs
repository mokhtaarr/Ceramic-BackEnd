using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("sys_AnalyticalCodeProccess")]
    public partial class SysAnalyticalCodeProccess
    {
        [Key]
        [Column("ANProcessId")]
        public int AnprocessId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(1000)]
        public string? Remarks { get; set; }
        [StringLength(1000)]
        public string? Remarks1 { get; set; }
        [StringLength(1000)]
        public string? Remarks2 { get; set; }
        [StringLength(1000)]
        public string? Remarks3 { get; set; }
        [StringLength(1000)]
        public string? Remarks4 { get; set; }
        [StringLength(1000)]
        public string? Remarks5 { get; set; }
        [StringLength(1000)]
        public string? Remarks6 { get; set; }
        [StringLength(1000)]
        public string? Remarks7 { get; set; }
        [StringLength(1000)]
        public string? Remarks8 { get; set; }
        [StringLength(1000)]
        public string? Remarks9 { get; set; }
        [StringLength(1000)]
        public string? Remarks10 { get; set; }

        [ForeignKey("Aid")]
        [InverseProperty("SysAnalyticalCodeProccesses")]
        public virtual SysAnalyticalCode? AidNavigation { get; set; }
    }
}
