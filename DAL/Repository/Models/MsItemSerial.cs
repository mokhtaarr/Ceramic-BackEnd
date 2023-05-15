using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_ItemSerials")]
    public partial class MsItemSerial
    {
        [Key]
        public int ItemSerialId { get; set; }
        public int? ItemCardId { get; set; }
        [Column("SRNo1")]
        [StringLength(100)]
        public string? Srno1 { get; set; }
        [Column("SRNo2")]
        [StringLength(100)]
        public string? Srno2 { get; set; }
        [Column("SRNo3")]
        [StringLength(100)]
        public string? Srno3 { get; set; }
        [Column("SRNo4")]
        [StringLength(100)]
        public string? Srno4 { get; set; }
        [Column("SRNo5")]
        [StringLength(100)]
        public string? Srno5 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Length { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Width { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Weight { get; set; }
        [StringLength(100)]
        public string? Color { get; set; }
        public int? PurInvId { get; set; }
        public int? RetPurchId { get; set; }
        public int? InvId { get; set; }
        public int? RetSaleId { get; set; }
        public int? StockRecId { get; set; }
        public int? DeliverId { get; set; }
        public int? TranId { get; set; }
        public int? SalesOrderId { get; set; }
        public int? StockAdjustId { get; set; }
        public int? TranReqId { get; set; }
        public int? PurInvItemCardId { get; set; }
        public int? InvItemCardId { get; set; }
        public int? DelivItemCardId { get; set; }
        public int? StockAdjustItemId { get; set; }
        public int? OrderDetailItemCardId { get; set; }
        public int? RetPurchItemCardId { get; set; }
        public int? RetItemCardId { get; set; }
        public int? StockRecItemCardId { get; set; }
        public int? TrItenCardId { get; set; }
        public int? TranReqItemCardId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? WarrantyStrtDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? WarrantyEndDate { get; set; }
        public bool? IsInOrOut { get; set; }
        public int? StorePartId { get; set; }
        public int? LotNumberExpiryId { get; set; }
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

        [ForeignKey("DelivItemCardId")]
        [InverseProperty("MsItemSerials")]
        public virtual MsDeliverItemCard? DelivItemCard { get; set; }
        [ForeignKey("InvItemCardId")]
        [InverseProperty("MsItemSerials")]
        public virtual MsSalesInvoiceItemCard? InvItemCard { get; set; }
        [ForeignKey("OrderDetailItemCardId")]
        [InverseProperty("MsItemSerials")]
        public virtual MsSalesOrderItemCard? OrderDetailItemCard { get; set; }
        [ForeignKey("PurInvItemCardId")]
        [InverseProperty("MsItemSerials")]
        public virtual MsPurchaseInvoiceItemCard? PurInvItemCard { get; set; }
        [ForeignKey("RetItemCardId")]
        [InverseProperty("MsItemSerials")]
        public virtual MsReturnSalesItemCard? RetItemCard { get; set; }
        [ForeignKey("RetPurchItemCardId")]
        [InverseProperty("MsItemSerials")]
        public virtual MsReturnPurchaseItem? RetPurchItemCard { get; set; }
        [ForeignKey("StockAdjustItemId")]
        [InverseProperty("MsItemSerials")]
        public virtual MsItemStockAdjustmentDetail? StockAdjustItem { get; set; }
        [ForeignKey("StockRecItemCardId")]
        [InverseProperty("MsItemSerials")]
        public virtual MsStockReceiptItemCard? StockRecItemCard { get; set; }
        [ForeignKey("TrItenCardId")]
        [InverseProperty("MsItemSerials")]
        public virtual MsStockTranItemCard? TrItenCard { get; set; }
        [ForeignKey("TranReqItemCardId")]
        [InverseProperty("MsItemSerials")]
        public virtual MsStockTranItemCardReq? TranReqItemCard { get; set; }
    }
}
