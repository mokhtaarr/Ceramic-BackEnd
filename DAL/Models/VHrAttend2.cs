using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VHrAttend2
    {
        public DateTime? ActualDate { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public DateTime? Dateat { get; set; }
        public TimeSpan? LogInTime { get; set; }
        public TimeSpan? LogOutTime { get; set; }
    }
}
