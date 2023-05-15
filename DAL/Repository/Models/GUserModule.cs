using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("G_USER_MODULE")]
    public partial class GUserModule
    {
        [Key]
        public int UserModuleId { get; set; }
        public int UserId { get; set; }
        [StringLength(100)]
        public string ModuleCode { get; set; } = null!;
        [StringLength(100)]
        public string? ModuleDescA { get; set; }
        public bool CanOpen { get; set; }
        public bool CanCreate { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanPrint { get; set; }
        public bool CanPreView { get; set; }
        public bool CanPost { get; set; }
        public byte? PrintCopies { get; set; }
        public bool? PrintWithSave { get; set; }
        [StringLength(150)]
        public string? DefaultReport { get; set; }
        [Column("CUSTOM1")]
        public bool Custom1 { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("GUserModules")]
        public virtual GUser User { get; set; } = null!;
    }
}
