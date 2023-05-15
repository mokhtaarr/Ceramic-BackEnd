using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_BoxTransferDetail")]
    public partial class MsBoxTransferDetail
    {
        [Key]
        public int BoxTranDetailId { get; set; }
        public int? BoxTranId { get; set; }
        public int? BoxFrom { get; set; }
        public int? BoxTo { get; set; }
        public int? CurrencyId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column("valu", TypeName = "numeric(38, 10)")]
        public decimal? Valu { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey("BoxTranId")]
        [InverseProperty("MsBoxTransferDetails")]
        public virtual MsBoxTransferNote? BoxTran { get; set; }
    }
}
