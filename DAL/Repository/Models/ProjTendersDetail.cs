using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_TendersDetails")]
    public partial class ProjTendersDetail
    {
        [Key]
        public int TenderDetailId { get; set; }
        public int? TenderId { get; set; }
        public int? TenderItemId { get; set; }
        public int? ParentTenderItemId { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
        public int? BasUnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        public byte? ItemStatus { get; set; }
        [StringLength(100)]
        public string? ItemStatusDesc { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        [StringLength(200)]
        public string? Remarks4 { get; set; }

        [ForeignKey("TenderId")]
        [InverseProperty("ProjTendersDetails")]
        public virtual ProjTender? Tender { get; set; }
    }
}
