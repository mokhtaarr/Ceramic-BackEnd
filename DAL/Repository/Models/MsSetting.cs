using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_Settings")]
    public partial class MsSetting
    {
        [Key]
        public int SettingId { get; set; }
        public bool? ExpUseColor { get; set; }
        public int? ExpPeriod { get; set; }
        [Column("chekAlert")]
        public bool? ChekAlert { get; set; }
        public bool? ItemLimitAlert { get; set; }
        public bool? ItemMaxAlert { get; set; }
        public bool? AlertCustCredit { get; set; }
        public bool? AlertVendCredit { get; set; }
        public int? AlertTimeOut { get; set; }
        public bool? CustCodOrNam { get; set; }
        public bool? VendCodOrNam { get; set; }
        public bool? PartCodOrNam { get; set; }
        public byte? AccountsDecimals { get; set; }
        public byte? QuantityDicimals { get; set; }
        public byte? PriceDicimals { get; set; }
        public byte? CostDicimals { get; set; }
        public byte? ValuesDicimals { get; set; }
        public byte? PercentDicimals { get; set; }
        public byte? DimensionDicimals { get; set; }
        public byte? TimeDecimals { get; set; }
        public bool? UseBarCodes { get; set; }
        public bool? UseBasicOrAlterBarcod { get; set; }
        public bool? UseSerialNumber { get; set; }
        public bool? UseExpirySystem { get; set; }
        public bool? UseExpiryDateColumn { get; set; }
        public bool? UseProducDateColumn { get; set; }
        public bool? UseLotNumberColumn { get; set; }
        public bool? UseAlterItems { get; set; }
        public bool? UseAttributes { get; set; }
        public bool? UseHightColumn { get; set; }
        public bool? UseWidthColumn { get; set; }
        public bool? UseLengthColumn { get; set; }
        public bool? UseUnitColumn { get; set; }
        public bool? UseBrancheCodeColumn { get; set; }
        public bool? UseBrancheNameColumn { get; set; }
        public bool? UsePartitionCodeColumn { get; set; }
        public bool? UsePartitionNameColumn { get; set; }
        public byte? NoOfItemRemarksFields { get; set; }
        [StringLength(50)]
        public string? ItemCostAffectDoc { get; set; }
        [StringLength(50)]
        public string? SalesReturnItemCost { get; set; }
        [StringLength(50)]
        public string? PurchReturnItemCost { get; set; }
        /// <summary>
        /// 1 always copy, 2 always move,3 never copy or move,4 ask to move
        /// </summary>
        public byte? AskForAttachMove { get; set; }
        [StringLength(2500)]
        public string? AttachmentPath { get; set; }
        public bool? UseWeightCardSystem { get; set; }
        public bool? UseCurrency { get; set; }
        public bool? UseHijiryDate { get; set; }
        [StringLength(10)]
        public string? SysDateFormat { get; set; }
        public bool? ScaleAutoRead { get; set; }
        [StringLength(2500)]
        public string? ScaleAppPath { get; set; }
        [StringLength(2500)]
        public string? ScaleDataPath { get; set; }
        public byte? ItemIssueCostMethod { get; set; }
        public byte? ItemIssueWhichCost { get; set; }
        public bool? UseFinancialQtyOnly { get; set; }
        public bool? UseSimpleExpirySystem { get; set; }
        public bool? UseComposItem { get; set; }
        public bool? HideDeletedDocs { get; set; }
        public bool? HideCustBranch { get; set; }
        public bool? HideCurrency { get; set; }
        public bool? HideSalesMan { get; set; }
        public bool? HideMoneyCollector { get; set; }
        public bool? DistDiscOnJobOrderItems { get; set; }
        public bool? UseSalesJobOrders { get; set; }
        public bool? UseItemTaxInPurch { get; set; }
        public bool? UseItemTaxInSales { get; set; }
        public bool? UseAnalyticalCode { get; set; }
        public bool? UseShipping { get; set; }
        public bool? UseVehicles { get; set; }
        public int? ItemDefTax { get; set; }
        public bool? PriceIncludTaxInSales { get; set; }
        public bool? PriceIncludTaxInPurch { get; set; }
        public bool? SearchItemWithQtySales { get; set; }
        public bool? UseCatCodInItems { get; set; }
        [StringLength(10)]
        public string? ItemSeparator { get; set; }
        public bool? UseCatCodInCust { get; set; }
        [StringLength(10)]
        public string? CustSeparator { get; set; }
        public bool? UseCatCodInVend { get; set; }
        [StringLength(10)]
        public string? VendSeparator { get; set; }
        [Column("ETaxClientId")]
        [StringLength(200)]
        public string? EtaxClientId { get; set; }
        [Column("ETaxClientSecret")]
        [StringLength(200)]
        public string? EtaxClientSecret { get; set; }
        [Column("ETaxPortalUrl")]
        [StringLength(300)]
        public string? EtaxPortalUrl { get; set; }
        [Column("ETaxTokenUrl")]
        [StringLength(300)]
        public string? EtaxTokenUrl { get; set; }
        [Column("ETaxSubmitUrl")]
        [StringLength(300)]
        public string? EtaxSubmitUrl { get; set; }
        [Column("ETaxActivityCode")]
        [StringLength(50)]
        public string? EtaxActivityCode { get; set; }
        [Column("ETaxIssuerId")]
        [StringLength(50)]
        public string? EtaxIssuerId { get; set; }
        [Column("ETaxIssuerName")]
        [StringLength(200)]
        public string? EtaxIssuerName { get; set; }
        [Column("ETaxTokenPin")]
        [StringLength(50)]
        public string? EtaxTokenPin { get; set; }
        [Column("ETaxInvoiceStatus")]
        [StringLength(20)]
        public string? EtaxInvoiceStatus { get; set; }
        [Column("ETaxCurrency")]
        [StringLength(20)]
        public string? EtaxCurrency { get; set; }
        [Column("ETaxBranchId")]
        [StringLength(100)]
        public string? EtaxBranchId { get; set; }
        [StringLength(20)]
        public string? EtaxTax { get; set; }
        [StringLength(20)]
        public string? EtaxDocVersion { get; set; }
        [Column("ETaxPortalUrlTest")]
        [StringLength(300)]
        public string? EtaxPortalUrlTest { get; set; }
        [Column("ETaxTokenUrlTest")]
        [StringLength(300)]
        public string? EtaxTokenUrlTest { get; set; }
        [Column("ETaxSubmitUrlTest")]
        [StringLength(300)]
        public string? EtaxSubmitUrlTest { get; set; }
        [Column("ETaxPortalUrlLive")]
        [StringLength(300)]
        public string? EtaxPortalUrlLive { get; set; }
        [Column("ETaxTokenUrlLive")]
        [StringLength(300)]
        public string? EtaxTokenUrlLive { get; set; }
        [Column("ETaxSubmitUrlLive")]
        [StringLength(300)]
        public string? EtaxSubmitUrlLive { get; set; }
        public bool? ActivateUnit2 { get; set; }
        public bool? JoinBranches { get; set; }
    }
}
