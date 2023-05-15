using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_BoxBank")]
    public partial class MsBoxBank
    {
        public MsBoxBank()
        {
            MsBoxCurrencies = new HashSet<MsBoxCurrency>();
            MsBoxUsers = new HashSet<MsBoxUser>();
            MsPaymentNotes = new HashSet<MsPaymentNote>();
            MsReceiptNotes = new HashSet<MsReceiptNote>();
            MsStores = new HashSet<MsStore>();
        }

        /// <summary>
        /// 0 Box ,1  Bank
        /// </summary>
        [Key]
        public int BoxId { get; set; }
        [StringLength(50)]
        public string BoxCode { get; set; } = null!;
        [Column("DESCA")]
        [StringLength(100)]
        public string? Desca { get; set; }
        [Column("DESCE")]
        [StringLength(100)]
        public string? Desce { get; set; }
        public int? AccountId { get; set; }
        public int? StoreId { get; set; }
        [StringLength(100)]
        public string? KeeperName { get; set; }
        [StringLength(50)]
        public string? BankResposableName { get; set; }
        [StringLength(20)]
        public string? BankTel { get; set; }
        [StringLength(20)]
        public string? BankMobile { get; set; }
        [StringLength(20)]
        public string? BankFax { get; set; }
        public bool? IsActive { get; set; }
        /// <summary>
        /// 0 Box ; 1 Bank
        /// </summary>
        public bool? IsBank { get; set; }
        [Column("CheckPrintID")]
        public int? CheckPrintId { get; set; }
        public bool? ForAdjustOnly { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }

        [InverseProperty("Box")]
        public virtual ICollection<MsBoxCurrency> MsBoxCurrencies { get; set; }
        [InverseProperty("Box")]
        public virtual ICollection<MsBoxUser> MsBoxUsers { get; set; }
        [InverseProperty("Box")]
        public virtual ICollection<MsPaymentNote> MsPaymentNotes { get; set; }
        [InverseProperty("Box")]
        public virtual ICollection<MsReceiptNote> MsReceiptNotes { get; set; }
        [InverseProperty("Box")]
        public virtual ICollection<MsStore> MsStores { get; set; }
    }
}
