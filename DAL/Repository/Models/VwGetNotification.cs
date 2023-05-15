using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetNotification
    {
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
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? WachDate { get; set; }
        public bool? Closed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ClosedDate { get; set; }
        [StringLength(250)]
        public string? Message { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }
        [Column("currentUser")]
        [StringLength(101)]
        public string? CurrentUser { get; set; }
        [StringLength(101)]
        public string? SenderUser { get; set; }
        [StringLength(50)]
        public string? UserCode { get; set; }
        public int? EmpId { get; set; }
        public byte? UserType { get; set; }
        [StringLength(50)]
        public string? DepartCode { get; set; }
        [StringLength(100)]
        public string? DepartName1 { get; set; }
        [StringLength(100)]
        public string? DepartName2 { get; set; }
    }
}
