using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VHrAttendAll
    {
        public int? Code { get; set; }
        public string Name { get; set; }
        public DateTime? Dateat { get; set; }
        public TimeSpan? LogInTime { get; set; }
        public TimeSpan? LogOutTime { get; set; }
        public int? RolId { get; set; }
        public int? DevId { get; set; }
    }
}
