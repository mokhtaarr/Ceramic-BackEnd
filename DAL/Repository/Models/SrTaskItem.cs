using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_TaskItem")]
    public partial class SrTaskItem
    {
        [Key]
        public int TskItemId { get; set; }
        public int? TaskId { get; set; }
        public int? ItemCardId { get; set; }
        [StringLength(500)]
        public string? HowUse { get; set; }

        [ForeignKey("ItemCardId")]
        [InverseProperty("SrTaskItems")]
        public virtual MsItemCard? ItemCard { get; set; }
        [ForeignKey("TaskId")]
        [InverseProperty("SrTaskItems")]
        public virtual SrTask? Task { get; set; }
    }
}
