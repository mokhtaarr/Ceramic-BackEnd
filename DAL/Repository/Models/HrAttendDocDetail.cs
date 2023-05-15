using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_AttendDocDetails")]
    public partial class HrAttendDocDetail
    {
        [Key]
        public int AttendDocDetailsId { get; set; }
        public int? AttendDocId { get; set; }
        public int? EmpId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AttendDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DismissDate { get; set; }
        public int? ShiftId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftFrom { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftTo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftFrom { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftTo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftFrom { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftTo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AttenDelayByMinutes { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AttenDelayByHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AttenDelayByDays { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyAttendByMinutes { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyAttendByHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyAttendByDays { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyLeaveByMinutes { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyLeaveByHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyLeaveByDays { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OverTimeByMinutes { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OverTimeByHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? OverTimeByDays { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetTimeByMinutes { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetTimeByHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetTimeByDays { get; set; }
        public int? LeavPermisionId1 { get; set; }
        public int? LeavPermisionId2 { get; set; }
        public int? LeavPermisionId3 { get; set; }
        public int? LeavPermisionId4 { get; set; }
        public int? LeavPermisionId5 { get; set; }
        public int? LeavPermisionId6 { get; set; }

        [ForeignKey("AttendDocId")]
        [InverseProperty("HrAttendDocDetails")]
        public virtual HrAttendanceDoc? AttendDoc { get; set; }
    }
}
