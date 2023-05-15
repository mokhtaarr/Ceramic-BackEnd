using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_JobOrder")]
    public partial class ProdJobOrder
    {
        public ProdJobOrder()
        {
            MsSalesInvJobOrderJoins = new HashSet<MsSalesInvJobOrderJoin>();
            ProdJobOrderEquipments = new HashSet<ProdJobOrderEquipment>();
            ProdJobOrderExpenses = new HashSet<ProdJobOrderExpense>();
            ProdJobOrderGoStocks = new HashSet<ProdJobOrderGoStock>();
            ProdJobOrderJobs = new HashSet<ProdJobOrderJob>();
            ProdJobOrderMaterials = new HashSet<ProdJobOrderMaterial>();
            ProdJobOrderProducts = new HashSet<ProdJobOrderProduct>();
            ProdJobOrderPurchaseInvoices = new HashSet<ProdJobOrderPurchaseInvoice>();
            ProdJobOrderScraps = new HashSet<ProdJobOrderScrap>();
            ProdJobOrderServices = new HashSet<ProdJobOrderService>();
            ProdJobOrderTasks = new HashSet<ProdJobOrderTask>();
            ProdJobOrderWorkFlows = new HashSet<ProdJobOrderWorkFlow>();
        }

        [Key]
        public int JobOrderId { get; set; }
        [Column("JOrderTypeId")]
        public int? JorderTypeId { get; set; }
        public int? SerReqId { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public int? StoreId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? AccountId { get; set; }
        public int? InDirectExpensesAccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? PurInvId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? CustomerId { get; set; }
        public int? ClientId { get; set; }
        public int? DepartMentId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public int? CurrencyId { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [StringLength(200)]
        public string? Name1 { get; set; }
        [StringLength(200)]
        public string? Name2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public byte? OrderSource { get; set; }
        public byte? OrderType { get; set; }
        public byte? Priority { get; set; }
        public byte? OrderStatus { get; set; }
        public bool? Installation { get; set; }
        public int? MaintainTypeId { get; set; }
        [StringLength(100)]
        public string? RefOrder { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ToDate { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProducedQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalTasksCose { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalJobsCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalEquipCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalExpensesCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CustomerCharged { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetExpenses { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPurchInvCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalServices { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalJpbOrder { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalProductsPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalGoStock { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalScrap { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? InstallationPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DiscAmount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalMaterialCostEstimate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalGoStockCostEstimate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalScrapCostEstimate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalProductCostEstimate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalEquipCostEstimate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalJobsCostEstimate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalExpensCostEstimate { get; set; }
        public bool? IsDeliveredGoStock { get; set; }
        public bool? IsDeliveredProducts { get; set; }
        public bool? IsDeliveredScrap { get; set; }
        public bool? IsDeliveredMaterial { get; set; }
        public bool? IsPaid { get; set; }
        public int? PaidDocId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NotPaid { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalProducedMeter { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
        public int? ShiftId { get; set; }
        public bool? IsService { get; set; }
        /// <summary>
        /// 1 Fattening, 2 Feeding
        /// </summary>
        public byte? FatteningType { get; set; }
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

        [InverseProperty("JobOrder")]
        public virtual ICollection<MsSalesInvJobOrderJoin> MsSalesInvJobOrderJoins { get; set; }
        [InverseProperty("JobOrder")]
        public virtual ICollection<ProdJobOrderEquipment> ProdJobOrderEquipments { get; set; }
        [InverseProperty("JobOrder")]
        public virtual ICollection<ProdJobOrderExpense> ProdJobOrderExpenses { get; set; }
        [InverseProperty("JobOrder")]
        public virtual ICollection<ProdJobOrderGoStock> ProdJobOrderGoStocks { get; set; }
        [InverseProperty("JobOrder")]
        public virtual ICollection<ProdJobOrderJob> ProdJobOrderJobs { get; set; }
        [InverseProperty("JobOrder")]
        public virtual ICollection<ProdJobOrderMaterial> ProdJobOrderMaterials { get; set; }
        [InverseProperty("JobOrder")]
        public virtual ICollection<ProdJobOrderProduct> ProdJobOrderProducts { get; set; }
        [InverseProperty("JobOrder")]
        public virtual ICollection<ProdJobOrderPurchaseInvoice> ProdJobOrderPurchaseInvoices { get; set; }
        [InverseProperty("JobOrder")]
        public virtual ICollection<ProdJobOrderScrap> ProdJobOrderScraps { get; set; }
        [InverseProperty("JobOrder")]
        public virtual ICollection<ProdJobOrderService> ProdJobOrderServices { get; set; }
        [InverseProperty("JobOrder")]
        public virtual ICollection<ProdJobOrderTask> ProdJobOrderTasks { get; set; }
        [InverseProperty("JobOrder")]
        public virtual ICollection<ProdJobOrderWorkFlow> ProdJobOrderWorkFlows { get; set; }
    }
}
