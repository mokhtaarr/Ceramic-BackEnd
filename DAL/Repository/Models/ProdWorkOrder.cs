﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_WorkOrder")]
    public partial class ProdWorkOrder
    {
        public ProdWorkOrder()
        {
            ProdWorkOrderEquipments = new HashSet<ProdWorkOrderEquipment>();
            ProdWorkOrderExpenses = new HashSet<ProdWorkOrderExpense>();
            ProdWorkOrderItemRecQualityDocs = new HashSet<ProdWorkOrderItemRecQualityDoc>();
            ProdWorkOrderMaterials = new HashSet<ProdWorkOrderMaterial>();
            ProdWorkOrderProdItems = new HashSet<ProdWorkOrderProdItem>();
            ProdWorkOrderServices = new HashSet<ProdWorkOrderService>();
            QualityItemRecPackages = new HashSet<QualityItemRecPackage>();
        }

        [Key]
        public int WorkOrderId { get; set; }
        public int? StoreEmpId { get; set; }
        public int? StoreId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        public int? TotalPieces { get; set; }
        [StringLength(200)]
        public string? DocBarCode { get; set; }
        public bool? Executed { get; set; }
        public int? PackageCount { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
        [StringLength(100)]
        public string? AddField3 { get; set; }
        [StringLength(100)]
        public string? AddField4 { get; set; }
        [StringLength(100)]
        public string? AddField5 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalItemCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalEquipCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalExpensesCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CustomerCharged { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalServices { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NetExpenses { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalJpbOrder { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalScrap { get; set; }
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
        public decimal? TotalExpensCostEstimate { get; set; }
        public bool? IsDeliveredProducts { get; set; }
        public bool? IsDeliveredScrap { get; set; }
        public bool? IsDeliveredMaterial { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
        public bool? Closed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PermPrintedAt { get; set; }
        public bool? IsPos { get; set; }
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
        public int? ShiftId { get; set; }

        [InverseProperty("WorkOrder")]
        public virtual ICollection<ProdWorkOrderEquipment> ProdWorkOrderEquipments { get; set; }
        [InverseProperty("WorkOrder")]
        public virtual ICollection<ProdWorkOrderExpense> ProdWorkOrderExpenses { get; set; }
        [InverseProperty("WorkOrder")]
        public virtual ICollection<ProdWorkOrderItemRecQualityDoc> ProdWorkOrderItemRecQualityDocs { get; set; }
        [InverseProperty("WorkOrder")]
        public virtual ICollection<ProdWorkOrderMaterial> ProdWorkOrderMaterials { get; set; }
        [InverseProperty("WorkOrder")]
        public virtual ICollection<ProdWorkOrderProdItem> ProdWorkOrderProdItems { get; set; }
        [InverseProperty("WorkOrder")]
        public virtual ICollection<ProdWorkOrderService> ProdWorkOrderServices { get; set; }
        [InverseProperty("WorkOrder")]
        public virtual ICollection<QualityItemRecPackage> QualityItemRecPackages { get; set; }
    }
}