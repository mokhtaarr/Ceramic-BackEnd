using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_PeriodsTables")]
    public partial class HrPeriodsTable
    {
        public HrPeriodsTable()
        {
            HrEmployees = new HashSet<HrEmployee>();
            HrPeriodTableDetails = new HashSet<HrPeriodTableDetail>();
            HrPeriodTablePolicies = new HashSet<HrPeriodTablePolicy>();
            HrPeriodTableVacations = new HashSet<HrPeriodTableVacation>();
        }

        [Key]
        public int PeriodTableId { get; set; }
        [StringLength(50)]
        public string? PeriodCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public bool? AttendanceMachin { get; set; }
        public int? ShiftId { get; set; }
        public byte? PeriodsNum { get; set; }
        public byte? PeriodType { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TableStartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TableEndDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstDayWork { get; set; }
        public byte? PeriodWorkDays { get; set; }
        public byte? DailyWorkHours { get; set; }
        [Column(TypeName = "numeric(5, 2)")]
        public decimal? SubPeriodCount { get; set; }
        public byte? SubPeriodType { get; set; }
        public byte? RoundingMethod { get; set; }
        public int? WorkDayShowElementId { get; set; }
        public int? WorkDayNoShowElementId { get; set; }
        public int? Shift1ShowElementId { get; set; }
        public int? Shift1NoShowElementId { get; set; }
        public int? Shift2ShowElementId { get; set; }
        public int? Shift2NoShowElementId { get; set; }
        public int? Shift3ShowElementId { get; set; }
        public int? Shift3NoShowElementId { get; set; }
        public int? LateArrivalElementId { get; set; }
        [StringLength(20)]
        public string? LateArrivalUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LateArrivalRound { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LateArrivalMinVal { get; set; }
        public int? EarlyLeaveElementId { get; set; }
        [StringLength(20)]
        public string? EarlyLeaveUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyLeaveRound { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyLeaveMinVal { get; set; }
        public int? EarlyAttendElementId { get; set; }
        [StringLength(20)]
        public string? EarlyAttendUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyAttendRound { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EarlyAttendMinVal { get; set; }
        public int? WorkdayOvertimeElementId { get; set; }
        [StringLength(20)]
        public string? WorkdayOvertimeUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WorkdayOvertimeRound { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WorkdayOvertimeMinVal { get; set; }
        public int? VacationOvertimeElementId { get; set; }
        [StringLength(20)]
        public string? VacationOvertimeUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? VacationOvertimeRound { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? VacationOvertimeMinVal { get; set; }
        public int? WeekendOvertimeElementId { get; set; }
        [StringLength(20)]
        public string? WeekendOvertimeUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeekendOvertimeRound { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeekendOvertimeMinVal { get; set; }
        public byte? WrkOvrTimAfterDismis { get; set; }
        public byte? WeekEndOvrTimAftrDismis { get; set; }
        public byte? VacOvrTimAftrDismis { get; set; }
        /// <summary>
        /// قبول تعويض الورديات فى أيام الأجازات
        /// </summary>
        public bool? AcceptShiftVacs { get; set; }
        /// <summary>
        /// اعتبار تحقيق الورديه بمجرد تحقيق عدد ساعات الورديه بغض النظر عن توقيت الحضور و الانصراف
        /// </summary>
        public bool? AcceptShiftHours { get; set; }
        /// <summary>
        /// عدم احتساب الورديه فى حالة خروج الموظف فى منتصف اليوم قبل ميعاد الانصراف
        /// </summary>
        public bool? ShiftNotAcheived { get; set; }
        /// <summary>
        /// احتساب الورديه فى حالة خروج الموظف و رجوعه قبل ميعاد الانصراف مع تجاهل عدد الساعات المحققه
        /// </summary>
        public bool? AcceptShftBeforDismis { get; set; }
        /// <summary>
        /// خصم التأخير و الانصراف المبكر من الوقت الاضافى لنفس اليوم
        /// </summary>
        public bool? CutLateTimFromOverTime { get; set; }
        /// <summary>
        /// الغاء الانصراف المبكر فى حالة تسجيل حضور ثانى فى نفس اليوم
        /// </summary>
        public bool? CancelEarlyLeave { get; set; }
        public bool? CalcEarlyLeaveWeekEnd { get; set; }
        public bool? CalcEarlyLeaveVacation { get; set; }
        public bool? CalcLateAttendWeekEnd { get; set; }
        public bool? CalcLateAttendVacation { get; set; }
        public int? WeekEndWorkDayElementId { get; set; }
        [StringLength(20)]
        public string? WeekEndWorkUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeekEndWorkRound { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeekEndWorkMinVal { get; set; }
        public int? VacationWorkDayElementId { get; set; }
        [StringLength(20)]
        public string? VacationWorkUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? VacationWorkRound { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? VacationWorkMinVal { get; set; }
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

        [InverseProperty("PeriodTable")]
        public virtual ICollection<HrEmployee> HrEmployees { get; set; }
        [InverseProperty("PeriodTable")]
        public virtual ICollection<HrPeriodTableDetail> HrPeriodTableDetails { get; set; }
        [InverseProperty("PeriodTable")]
        public virtual ICollection<HrPeriodTablePolicy> HrPeriodTablePolicies { get; set; }
        [InverseProperty("PeriodTable")]
        public virtual ICollection<HrPeriodTableVacation> HrPeriodTableVacations { get; set; }
    }
}
