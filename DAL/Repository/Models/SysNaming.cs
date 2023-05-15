using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sys_Naming")]
    public partial class SysNaming
    {
        [Key]
        public int NamingId { get; set; }
        [StringLength(50)]
        public string? Culture { get; set; }
        [StringLength(50)]
        public string? Screen { get; set; }
        [StringLength(100)]
        public string? CtrlName { get; set; }
        [StringLength(150)]
        public string? CtrlOriginalText { get; set; }
        [StringLength(150)]
        public string? CtrlNewText { get; set; }
        [StringLength(150)]
        public string? CtrlTextBefore { get; set; }
        public int? UserId { get; set; }
        public bool? IsAllUsers { get; set; }
        public bool? HasFlexFields { get; set; }
        [StringLength(100)]
        public string? FlexMasterCardTable { get; set; }
        [StringLength(100)]
        public string? SelectedField { get; set; }
        public bool? MustSelect { get; set; }
        public bool? Hidden { get; set; }
        public int? CtrlLocationX { get; set; }
        public int? CtrlLocationY { get; set; }
        [Column("CtrlParentIsTPL")]
        public bool? CtrlParentIsTpl { get; set; }
        [StringLength(150)]
        public string? CtrlParent { get; set; }
        [StringLength(100)]
        public string? CtrlParentType { get; set; }
        [StringLength(100)]
        public string? CtrlType { get; set; }
        public bool? IsDropDown { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
    }
}
