using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_POSSettings")]
    public partial class MsPossetting
    {
        [Key]
        public int PosSetId { get; set; }
        public int? DefCustomerId { get; set; }
        public int? DefEmpId { get; set; }
        public int? BookId { get; set; }
        public int? RetBookId { get; set; }
        public int? CashTermId { get; set; }
        public int? CreditTermId { get; set; }
        public int? PayMethodTermId { get; set; }
        public int? ReturnCashTermId { get; set; }
        public int? ReturnCreditTermId { get; set; }
        public int? ReturnPayMethodTermId { get; set; }
        public bool? UseItemDefStorIfNoQty { get; set; }
        public bool? MinusNoteQty { get; set; }
        public bool? UseOffers { get; set; }
        [Column("cmdNew")]
        [StringLength(20)]
        public string? CmdNew { get; set; }
        [Column("cmdNew2")]
        [StringLength(20)]
        public string? CmdNew2 { get; set; }
        [Column("cmdEdit")]
        [StringLength(20)]
        public string? CmdEdit { get; set; }
        [Column("cmdEdit2")]
        [StringLength(20)]
        public string? CmdEdit2 { get; set; }
        [Column("cmdPreview")]
        [StringLength(20)]
        public string? CmdPreview { get; set; }
        [Column("cmdPreview2")]
        [StringLength(20)]
        public string? CmdPreview2 { get; set; }
        [Column("cmdPrint")]
        [StringLength(20)]
        public string? CmdPrint { get; set; }
        [Column("cmdPrint2")]
        [StringLength(20)]
        public string? CmdPrint2 { get; set; }
        [Column("cmdSave")]
        [StringLength(20)]
        public string? CmdSave { get; set; }
        [Column("cmdSave2")]
        [StringLength(20)]
        public string? CmdSave2 { get; set; }
        [Column("cmdPay")]
        [StringLength(20)]
        public string? CmdPay { get; set; }
        [Column("cmdPay2")]
        [StringLength(20)]
        public string? CmdPay2 { get; set; }
        [Column("cmdCredit")]
        [StringLength(20)]
        public string? CmdCredit { get; set; }
        [Column("cmdCredit2")]
        [StringLength(20)]
        public string? CmdCredit2 { get; set; }
        [Column("cmdHold")]
        [StringLength(20)]
        public string? CmdHold { get; set; }
        [Column("cmdHold2")]
        [StringLength(20)]
        public string? CmdHold2 { get; set; }
        [Column("cmdDelete")]
        [StringLength(20)]
        public string? CmdDelete { get; set; }
        [Column("cmdDelete2")]
        [StringLength(20)]
        public string? CmdDelete2 { get; set; }
        [Column("cmdDiscount")]
        [StringLength(20)]
        public string? CmdDiscount { get; set; }
        [Column("cmdDiscount2")]
        [StringLength(20)]
        public string? CmdDiscount2 { get; set; }
        [Column("cmdShortage")]
        [StringLength(20)]
        public string? CmdShortage { get; set; }
        [Column("cmdShortage2")]
        [StringLength(20)]
        public string? CmdShortage2 { get; set; }
        [Column("cmdDocSearch")]
        [StringLength(20)]
        public string? CmdDocSearch { get; set; }
        [Column("cmdDocSearch2")]
        [StringLength(20)]
        public string? CmdDocSearch2 { get; set; }
        [Column("cmdItemSearch1")]
        [StringLength(20)]
        public string? CmdItemSearch1 { get; set; }
        [Column("cmdItemSearch2")]
        [StringLength(20)]
        public string? CmdItemSearch2 { get; set; }
        [Column("cmdItemEdit")]
        [StringLength(20)]
        public string? CmdItemEdit { get; set; }
        [Column("cmdItemEdit2")]
        [StringLength(20)]
        public string? CmdItemEdit2 { get; set; }
        [Column("cmdDeleteItem")]
        [StringLength(20)]
        public string? CmdDeleteItem { get; set; }
        [Column("cmdDeleteItem2")]
        [StringLength(20)]
        public string? CmdDeleteItem2 { get; set; }
        [Column("cmdUndo")]
        [StringLength(20)]
        public string? CmdUndo { get; set; }
        [Column("cmdUndo2")]
        [StringLength(20)]
        public string? CmdUndo2 { get; set; }
        [Column("cmdRetWithInv")]
        [StringLength(20)]
        public string? CmdRetWithInv { get; set; }
        [Column("cmdRetWithInv2")]
        [StringLength(20)]
        public string? CmdRetWithInv2 { get; set; }
        [Column("cmdRetWithoutInv")]
        [StringLength(20)]
        public string? CmdRetWithoutInv { get; set; }
        [Column("cmdRetWithoutInv2")]
        [StringLength(20)]
        public string? CmdRetWithoutInv2 { get; set; }
        [Column("cmdFirst")]
        [StringLength(20)]
        public string? CmdFirst { get; set; }
        [Column("cmdFirst2")]
        [StringLength(20)]
        public string? CmdFirst2 { get; set; }
        [Column("cmdLast")]
        [StringLength(20)]
        public string? CmdLast { get; set; }
        [Column("cmdLast2")]
        [StringLength(20)]
        public string? CmdLast2 { get; set; }
        [Column("cmdPrevious")]
        [StringLength(20)]
        public string? CmdPrevious { get; set; }
        [Column("cmdPrevious2")]
        [StringLength(20)]
        public string? CmdPrevious2 { get; set; }
        [Column("cmdNext")]
        [StringLength(20)]
        public string? CmdNext { get; set; }
        [Column("cmdNext2")]
        [StringLength(20)]
        public string? CmdNext2 { get; set; }
        [Column("cmdOffer1")]
        [StringLength(20)]
        public string? CmdOffer1 { get; set; }
        [Column("cmdOffer2")]
        [StringLength(20)]
        public string? CmdOffer2 { get; set; }
        public int? CustomerAccountId { get; set; }
        public int? VendorAccountId { get; set; }
        public int? EmpAccountId { get; set; }
        public int? BasUnitId { get; set; }
        public int? BtnItemCatWidth { get; set; }
        public int? BtnItemCatHeight { get; set; }
        public int? BtnItemWidth { get; set; }
        public int? BtnItemHeight { get; set; }
        public int? BtnPayMethodWidth { get; set; }
        public int? BtnPayMethodHeight { get; set; }
    }
}
