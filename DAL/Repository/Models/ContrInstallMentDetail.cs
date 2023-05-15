using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Contr_InstallMentDetail")]
    public partial class ContrInstallMentDetail
    {
        [Key]
        public int InstallDetailId { get; set; }
        public int? InstallId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Serial { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PayDayDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InstallValu { get; set; }
        public bool? IsPaid { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PaidDate { get; set; }
        public int? RectId { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }

        [ForeignKey("InstallId")]
        [InverseProperty("ContrInstallMentDetails")]
        public virtual ContrInstallMent? Install { get; set; }
    }
}
