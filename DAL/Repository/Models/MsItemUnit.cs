using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ItemUnit")]
    public partial class MsItemUnit
    {
        public MsItemUnit()
        {
            MsDeliverItemCards = new HashSet<MsDeliverItemCard>();
            MsItemUnitPackingJoins = new HashSet<MsItemUnitPackingJoin>();
            MsPurchaseInvoiceItemCards = new HashSet<MsPurchaseInvoiceItemCard>();
            MsReturnPurchaseItems = new HashSet<MsReturnPurchaseItem>();
            MsReturnSalesItemCards = new HashSet<MsReturnSalesItemCard>();
            MsSalesInvoiceItemCards = new HashSet<MsSalesInvoiceItemCard>();
            MsStockReceiptItemCards = new HashSet<MsStockReceiptItemCard>();
            MsStockTranItemCards = new HashSet<MsStockTranItemCard>();
        }

        [Key]
        public int UnitId { get; set; }
        public int? ItemCardId { get; set; }
        public int? BasUnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnittRate { get; set; }
        [StringLength(50)]
        public string? UnitCode { get; set; }
        [StringLength(100)]
        public string? UnitNam { get; set; }
        [StringLength(100)]
        public string? UnitNameE { get; set; }
        [StringLength(10)]
        public string? Symbol { get; set; }
        [StringLength(60)]
        public string? BarCode1 { get; set; }
        [StringLength(60)]
        public string? BarCode2 { get; set; }
        [StringLength(60)]
        public string? BarCode3 { get; set; }
        [StringLength(60)]
        public string? BarCode4 { get; set; }
        [StringLength(60)]
        public string? BarCode5 { get; set; }
        [StringLength(60)]
        public string? BarCode6 { get; set; }
        [StringLength(60)]
        public string? BarCode7 { get; set; }
        [StringLength(60)]
        public string? BarCode8 { get; set; }
        [StringLength(60)]
        public string? BarCode9 { get; set; }
        [StringLength(60)]
        public string? BarCode10 { get; set; }
        [StringLength(60)]
        public string? BarCode11 { get; set; }
        [StringLength(60)]
        public string? BarCode12 { get; set; }
        [StringLength(60)]
        public string? BarCode13 { get; set; }
        [StringLength(60)]
        public string? BarCode14 { get; set; }
        [StringLength(60)]
        public string? BarCode15 { get; set; }
        public byte? DefaultBarCode { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ManualPurchasePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BeforLastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastSalePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCostManual { get; set; }
        public bool? IsDefaultSale { get; set; }
        public bool? IsDefaultPurchas { get; set; }
        public bool? IsBasicUnit { get; set; }
        public bool? IsNotRegular { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity3 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price4 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity4 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price5 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity5 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price6 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price7 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price8 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price9 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price10 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LeastSalesPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LeastProfitMargin { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Wheight { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? X { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Y { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Z { get; set; }
        [StringLength(50)]
        public string? EtaxUnitCode { get; set; }
        public bool? IsKarat { get; set; }
        public int? MainServerId { get; set; }

        [ForeignKey("BasUnitId")]
        [InverseProperty("MsItemUnits")]
        public virtual ProdBasicUnit? BasUnit { get; set; }
        [ForeignKey("ItemCardId")]
        [InverseProperty("MsItemUnits")]
        public virtual MsItemCard? ItemCard { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<MsDeliverItemCard> MsDeliverItemCards { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<MsItemUnitPackingJoin> MsItemUnitPackingJoins { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<MsPurchaseInvoiceItemCard> MsPurchaseInvoiceItemCards { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<MsReturnPurchaseItem> MsReturnPurchaseItems { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<MsReturnSalesItemCard> MsReturnSalesItemCards { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<MsSalesInvoiceItemCard> MsSalesInvoiceItemCards { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<MsStockReceiptItemCard> MsStockReceiptItemCards { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<MsStockTranItemCard> MsStockTranItemCards { get; set; }
    }
}
