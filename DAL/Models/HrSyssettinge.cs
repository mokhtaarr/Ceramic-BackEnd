using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrSyssettinge
    {
        public int Id { get; set; }
        public int? Devid { get; set; }
        public string Modrole { get; set; }
        public int? Countitertaion { get; set; }
        public TimeSpan? Timemodein { get; set; }
        public TimeSpan? Timemodout { get; set; }
        public string Modroleout { get; set; }
    }
}
