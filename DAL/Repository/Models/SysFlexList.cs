using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("sys_FlexLists")]
    public partial class SysFlexList
    {
        [Key]
        public int FlexListId { get; set; }
        public int? NamingId { get; set; }
        [StringLength(50)]
        public string? FlexCode { get; set; }
        [StringLength(100)]
        public string? FlexName1 { get; set; }
        [StringLength(100)]
        public string? FlexName2 { get; set; }
        [StringLength(100)]
        public string? TableCode { get; set; }
        [StringLength(100)]
        public string? FieldCode { get; set; }
        [StringLength(100)]
        public string? Value1 { get; set; }
        [StringLength(100)]
        public string? Value2 { get; set; }
        [StringLength(100)]
        public string? Value3 { get; set; }
        [StringLength(100)]
        public string? Value4 { get; set; }
        [StringLength(100)]
        public string? Value5 { get; set; }
        public bool? Enabled { get; set; }
        [StringLength(50)]
        public string? Culture { get; set; }
        public bool? AllLanguages { get; set; }
    }
}
