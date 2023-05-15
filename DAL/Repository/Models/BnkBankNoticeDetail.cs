using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("BNK_BankNoticeDetail")]
    public partial class BnkBankNoticeDetail
    {
        [Key]
        public int BankNoticDetailId { get; set; }
        public int? BankNoticId { get; set; }
        public int? RectId { get; set; }
        public int? PayId { get; set; }
        public bool? IsCollected { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CollectDate { get; set; }
        public bool? IsReturned { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnDate { get; set; }
        public bool? Canceled { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }
        public bool? IsTransferred { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TransferredAte { get; set; }

        [ForeignKey("BankNoticId")]
        [InverseProperty("BnkBankNoticeDetails")]
        public virtual BnkBankNotice? BankNotic { get; set; }
    }
}
