using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchRewardAndPenalty
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public int TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExecutDate { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(50)]
        public string? EmpCode { get; set; }
        [StringLength(100)]
        public string? EmpName1 { get; set; }
        [StringLength(100)]
        public string? EmpName2 { get; set; }
        public bool? IsReward { get; set; }
        [Column("JCode")]
        public bool? Jcode { get; set; }
        [Column("JName1")]
        [StringLength(100)]
        public string? Jname1 { get; set; }
        [Column("JName2")]
        [StringLength(100)]
        public string? Jname2 { get; set; }
        [StringLength(50)]
        public string? DepartCode { get; set; }
        [StringLength(100)]
        public string? DepartName1 { get; set; }
        [StringLength(100)]
        public string? DepartName2 { get; set; }
        [StringLength(50)]
        public string? StoreCode { get; set; }
        [StringLength(100)]
        public string? StoreDescA { get; set; }
        [StringLength(100)]
        public string? StoreDescE { get; set; }
        [StringLength(50)]
        public string? SalaryCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public int? BookId { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
    }
}
