using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_AttendDocFactElements")]
    public partial class HrAttendDocFactElement
    {
        [Key]
        public int FactAttendId { get; set; }
        public int? AttendDocId { get; set; }
        public int? EmpId { get; set; }
        public int? ShiftId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalWorkDaysPeriod { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalWorkHoursPeriod { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WorkDayShow { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WorkDayNoShow { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Shift1Show { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Shift1NoShow { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Shift2Show { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Shift2NoShow { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Shift3Show { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Shift3NoShow { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LateArrivalMinutes { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LateArrivalHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LateArrivalDays { get; set; }
        public byte? LateArrivalCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyLeaveMinutes { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyLeaveHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyLeaveDays { get; set; }
        public byte? EarlyLeaveCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyAttendMinutes { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyAttendHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyAttendDays { get; set; }
        public byte? EarlyAttendCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WorkdayOvertimeMinutes { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WorkdayOvertimeHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WorkdayOvertimeDays { get; set; }
        public byte? WorkdayOvertimeCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? VacationOvertimeMinutes { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? VacationOvertimeHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? VacationOvertimeDays { get; set; }
        public byte? VacationOvertimeCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeekendOvertimeMinutes { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeekendOvertimeHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeekendOvertimeDays { get; set; }
        public byte? WeekendOvertimeCount { get; set; }
        public int? WeekEndWorkShow { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeekEndWorkMinutes { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeekEndWorkHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeekEndWorkDays { get; set; }
        public int? VacationWorkShow { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? VacationWorkMinutes { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? VacationWorkHours { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? VacationWorkDays { get; set; }

        [ForeignKey("AttendDocId")]
        [InverseProperty("HrAttendDocFactElements")]
        public virtual HrAttendanceDoc? AttendDoc { get; set; }
    }
}
