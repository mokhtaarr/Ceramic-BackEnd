using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_JoinTaskEquipments")]
    public partial class ProdJoinTaskEquipment
    {
        [Key]
        public int TaskEquipJoinId { get; set; }
        public int? TaskId { get; set; }
        public int? EquipId { get; set; }
        public int? RequestedNumber { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("TaskId")]
        [InverseProperty("ProdJoinTaskEquipments")]
        public virtual ProdTask? Task { get; set; }
    }
}
