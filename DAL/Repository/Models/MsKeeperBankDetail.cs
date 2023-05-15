using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_KeeperBankDetail")]
    public partial class MsKeeperBankDetail
    {
        [Key]
        public int KeeperDetailId { get; set; }
        public int? KeeperId { get; set; }
        public int? RectId { get; set; }
        public bool? IsCollected { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CollectDate { get; set; }
        public bool? IsReturned { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnDate { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }
        public bool? IsTransferred { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TransferredAte { get; set; }

        [ForeignKey("KeeperId")]
        [InverseProperty("MsKeeperBankDetails")]
        public virtual MsKeeperBank? Keeper { get; set; }
    }
}
