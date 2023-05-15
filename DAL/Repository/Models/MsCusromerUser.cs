using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_CusromerUsers")]
    public partial class MsCusromerUser
    {
        [Key]
        public int CustUserId { get; set; }
        public int? CustomerId { get; set; }
        public int? UserId { get; set; }
        [StringLength(200)]
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

        [ForeignKey("CustomerId")]
        [InverseProperty("MsCusromerUsers")]
        public virtual MsCustomer? Customer { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("MsCusromerUsers")]
        public virtual GUser? User { get; set; }
    }
}
