using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_AccountUsers")]
    public partial class CalAccountUser
    {
        [Key]
        public int AccUserId { get; set; }
        public int? AccountId { get; set; }
        public int? UserId { get; set; }
        public int? ApprovedBy { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }
        public bool? TranAndView { get; set; }

        [ForeignKey("AccountId")]
        [InverseProperty("CalAccountUsers")]
        public virtual CalAccountChart? Account { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("CalAccountUsers")]
        public virtual GUser? User { get; set; }
    }
}
