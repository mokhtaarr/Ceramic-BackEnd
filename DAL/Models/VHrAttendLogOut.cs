using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VHrAttendLogOut
    {
        public int? Code { get; set; }
        public string Name { get; set; }
        public DateTime? Dateat { get; set; }
        public TimeSpan? LogOutTime { get; set; }
        public int? RolId { get; set; }
    }
}
