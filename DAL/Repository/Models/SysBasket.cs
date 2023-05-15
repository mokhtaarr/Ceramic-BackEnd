using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sys_Basket")]
    public partial class SysBasket
    {
        [Key]
        public int BasketId { get; set; }
        public int? UserId { get; set; }
        public int? DepartMentId { get; set; }
        public int? FromUser { get; set; }
        [StringLength(100)]
        public string? DocName { get; set; }
        [StringLength(100)]
        public string? DocTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TransferDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? WachDate { get; set; }
        public bool? Closed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ClosedDate { get; set; }
        [StringLength(250)]
        public string? Message { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
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
    }
}
