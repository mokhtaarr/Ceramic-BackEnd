using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_Accounts")]
    public partial class ProjAccount
    {
        [Key]
        public int ProjectAccId { get; set; }
        public int? ProjectId { get; set; }
        public int? AccountId { get; set; }
        [Column(TypeName = "numeric(25, 2)")]
        public decimal? Value { get; set; }

        [ForeignKey("ProjectId")]
        [InverseProperty("ProjAccounts")]
        public virtual ProjProject? Project { get; set; }
    }
}
