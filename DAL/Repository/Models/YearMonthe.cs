using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    public partial class YearMonthe
    {
        [Key]
        public int YearMonthId { get; set; }
        public int? FinancialYearsId { get; set; }
        [StringLength(50)]
        public string? MontnName { get; set; }
        public int? MonthDayes { get; set; }
        public bool? IsActual { get; set; }
        public bool? IsNonActual { get; set; }
        [StringLength(50)]
        public string? CustomField { get; set; }
    }
}
