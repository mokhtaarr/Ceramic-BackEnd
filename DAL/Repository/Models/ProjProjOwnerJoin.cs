using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjOwnerJoin")]
    public partial class ProjProjOwnerJoin
    {
        [Key]
        public int ProjOwnerJoinId { get; set; }
        public int? ProjectId { get; set; }
        public int? ResourceId { get; set; }
        public byte? ResourceType { get; set; }
        public int? ResourceAccountId { get; set; }
        public int? HelpAccId { get; set; }
        [StringLength(50)]
        public string? HelpAccType { get; set; }
        [StringLength(100)]
        public string? AccountDescription { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ShareValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SharePercent { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("ProjectId")]
        [InverseProperty("ProjProjOwnerJoins")]
        public virtual ProjProject? Project { get; set; }
    }
}
