using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_PettyPaymentJoin")]
    public partial class MsPettyPaymentJoin
    {
        [Key]
        public int PetyPayId { get; set; }
        public int? PayId { get; set; }
        public int? PettycashId { get; set; }

        [ForeignKey("PayId")]
        [InverseProperty("MsPettyPaymentJoins")]
        public virtual MsPaymentNote? Pay { get; set; }
        [ForeignKey("PettycashId")]
        [InverseProperty("MsPettyPaymentJoins")]
        public virtual MsPettycash? Pettycash { get; set; }
    }
}
