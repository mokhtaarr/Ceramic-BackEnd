using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_JobOrderType")]
    public partial class ProdJobOrderType
    {
        [Key]
        [Column("JOrderTypeId")]
        public int JorderTypeId { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public int? AccountId { get; set; }
        public int? InDirectExpensesAccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId2 { get; set; }
        public bool? ItemCostInPrcent { get; set; }
        public bool? ExpensesCostInPercent { get; set; }
        public bool? JobsCostInPercent { get; set; }
        public bool? MachineCostInPercent { get; set; }
        public int? FinishedItemStorePartId { get; set; }
        public int? MaterialItemStorePartId { get; set; }
        public int? GoStockItemStorePartId { get; set; }
        public int? ScrapItemStorePartId { get; set; }
        public int? FinishedItemRecBookId { get; set; }
        public int? MaterialItemDelBookId { get; set; }
        public int? GoStockItemRecBookId { get; set; }
        public int? ScrapItemRecBookId { get; set; }
        public int? FinishedItemRecTermId { get; set; }
        public int? MaterialItemDelTermId { get; set; }
        public int? GoStockItemRecTermId { get; set; }
        public int? ScrapItemRecTermId { get; set; }
        public int? FinishedItemRecJournalBookId { get; set; }
        public int? MaterialItemDelJournalBookId { get; set; }
        public int? GoStockItemRecJournalBookId { get; set; }
        public int? ScrapItemRecJournalBookId { get; set; }
        public int? FinishedItemRecJournalTermId { get; set; }
        public int? MaterialItemDelJournalTermId { get; set; }
        public int? GoStockItemRecJournalTermId { get; set; }
        public int? ScrapItemRecJournalTermId { get; set; }
        /// <summary>
        /// 0 store, 1 customer
        /// </summary>
        public byte? JobOrderMadeFor { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? IndirectMaterialCostPrcent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? IndirectJobsCostPrcent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? IndirectMachinesCostPrcent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? IndirectCostPrcent { get; set; }
        /// <summary>
        /// 1 food,2 animal
        /// </summary>
        public byte? AnimalOrFood { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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
    }
}
