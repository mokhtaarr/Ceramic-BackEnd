using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VHrActualAttend
    {
        public DateTime? ActualDate { get; set; }
        public string EmpCode { get; set; }
        public string DeviceEmpCode { get; set; }
        public string Name1 { get; set; }
        public int? ShiftId { get; set; }
        public int? DepartMentId { get; set; }
        public int? JobId { get; set; }
        public int EmpId { get; set; }
        public int? StoreId { get; set; }
    }
}
