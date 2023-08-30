using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrOp
    {
        public int Id { get; set; }
        public int? Code { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public string Login { get; set; }
        public int? Rolid { get; set; }
        public int? Devid { get; set; }
    }
}
