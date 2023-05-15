using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_PettyCashDetails")]
    public partial class MsPettyCashDetail
    {
        [Key]
        public int PettycashDetailId { get; set; }
        public int? PettycashId { get; set; }
        public int? ItemCardId { get; set; }
        public int? CustomerId { get; set; }
        public int? VendorId { get; set; }
        public int? EmpId { get; set; }
        public int? ExpensesId { get; set; }
        public int? AccountId { get; set; }
        public int? PurInvId { get; set; }
        public int? RetSaleId { get; set; }
        public int? CostCenterId { get; set; }
        public int? UnitId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ActionDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExecutedQty { get; set; }
        public byte? ItemType { get; set; }
        public bool? IsStockRelated { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterRate { get; set; }
        public bool? IsPurchase { get; set; }
        public bool? IsReturnSales { get; set; }
        [StringLength(100)]
        public string? Remark1 { get; set; }
        [StringLength(100)]
        public string? Remark2 { get; set; }
        [StringLength(100)]
        public string? Remark3 { get; set; }

        [ForeignKey("PettycashId")]
        [InverseProperty("MsPettyCashDetails")]
        public virtual MsPettycash? Pettycash { get; set; }
    }
}
