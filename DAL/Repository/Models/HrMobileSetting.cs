using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("HR_MobileSetting")]
    public partial class HrMobileSetting
    {
        [Key]
        public int HrMobSetId { get; set; }
        public int? DefPermReqBookId { get; set; }
        public int? DefVacReqBookId { get; set; }
        public int? DefLoanReqBookId { get; set; }
        public int? TermId { get; set; }
    }
}
