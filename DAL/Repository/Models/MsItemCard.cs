using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_ItemCard")]
    public partial class MsItemCard
    {
        public MsItemCard()
        {
            MsDeliverItemCards = new HashSet<MsDeliverItemCard>();
            MsItemAlternatives = new HashSet<MsItemAlternative>();
            MsItemCardOffers = new HashSet<MsItemCardOffer>();
            MsItemCollections = new HashSet<MsItemCollection>();
            MsItemImages = new HashSet<MsItemImage>();
            MsItemPartitions = new HashSet<MsItemPartition>();
            MsItemStartQties = new HashSet<MsItemStartQty>();
            MsItemStockAdjustmentDetails = new HashSet<MsItemStockAdjustmentDetail>();
            MsItemUnits = new HashSet<MsItemUnit>();
            MsItemVendors = new HashSet<MsItemVendor>();
            MsPurchOrderDetails = new HashSet<MsPurchOrderDetail>();
            MsPurchaseInvoiceItemCards = new HashSet<MsPurchaseInvoiceItemCard>();
            MsReturnPurchaseItems = new HashSet<MsReturnPurchaseItem>();
            MsReturnSalesItemCards = new HashSet<MsReturnSalesItemCard>();
            MsSalesInvoiceItemCards = new HashSet<MsSalesInvoiceItemCard>();
            MsSalesOfferItemCards = new HashSet<MsSalesOfferItemCard>();
            MsStockReceiptItemCards = new HashSet<MsStockReceiptItemCard>();
            MsStockTranItemCards = new HashSet<MsStockTranItemCard>();
            ProdItemAttributsJoins = new HashSet<ProdItemAttributsJoin>();
            ProdItemcardExpenses = new HashSet<ProdItemcardExpense>();
            ProdJobOrderProducts = new HashSet<ProdJobOrderProduct>();
            SrTaskItems = new HashSet<SrTaskItem>();
            SrVehicleItemCards = new HashSet<SrVehicleItemCard>();
        }

        [Key]
        public int ItemCardId { get; set; }
        public int? ItemCategoryId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? BasUnitId { get; set; }
        public int? CodingStoreId { get; set; }
        public int? ProductTypeId { get; set; }
        public int? BrandId { get; set; }
        public int? GradId { get; set; }
        public int? GramTypeId { get; set; }
        public int? SizeTypeId { get; set; }
        public int? AnTypeId { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string? Separator { get; set; }
        public int? TaxesId1 { get; set; }
        public bool? Tax1ForSale { get; set; }
        public bool? Tax1ForPurch { get; set; }
        /// <summary>
        /// 0 Percent , 1 value , 2 Without
        /// </summary>
        public byte? Tax1Style { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Tax1Rate { get; set; }
        public bool? Tax1IsAccomulative { get; set; }
        public bool? Tax1PlusOrMinus { get; set; }
        public int? TaxesId2 { get; set; }
        public bool? Tax2ForSale { get; set; }
        public bool? Tax2ForPurch { get; set; }
        /// <summary>
        /// 0 Percent , 1 value , 2 Without
        /// </summary>
        public byte? Tax2Style { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Tax2Rate { get; set; }
        public bool? Tax2IsAccomulative { get; set; }
        public bool? Tax2PlusOrMinus { get; set; }
        public int? TaxesId3 { get; set; }
        public bool? Tax3ForSale { get; set; }
        public bool? Tax3ForPurch { get; set; }
        /// <summary>
        /// 0 Percent , 1 value , 2 Without
        /// </summary>
        public byte? Tax3Style { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Tax3Rate { get; set; }
        public bool? Tax3IsAccomulative { get; set; }
        public bool? Tax3PlusOrMinus { get; set; }
        /// <summary>
        /// 1  Finished product,2 Material,3 non stock Item,4 Manufactured,5 vehicle
        /// </summary>
        public byte? ItemType { get; set; }
        [StringLength(50)]
        public string? ItemCode { get; set; }
        [StringLength(100)]
        public string? TaxItemCode { get; set; }
        [StringLength(200)]
        public string? ItemDescA { get; set; }
        [StringLength(200)]
        public string? ItemDescE { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyPartiation { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyInNotebook { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalCost { get; set; }
        public int? PurchaseNumber { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastSalePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BeforLastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCostManual { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ManualPurchasePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverage { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastPurchDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FirstQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? FirstPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SecandQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SecandPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ThridQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ThirdPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LargeQty { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LargePrice { get; set; }
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
        public decimal? QtyInBox { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? PurchasePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Wheight { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ServicePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProfitPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Kirat { get; set; }
        [Column("strCustm5")]
        [StringLength(20)]
        public string? StrCustm5 { get; set; }
        /// <summary>
        /// 1 animal, 2 food, 3 medicin
        /// </summary>
        public byte? AnimalClass { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
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
        [StringLength(100)]
        public string? AddField6 { get; set; }
        [StringLength(100)]
        public string? AddField7 { get; set; }
        [StringLength(100)]
        public string? AddField8 { get; set; }
        [StringLength(100)]
        public string? AddField9 { get; set; }
        [StringLength(100)]
        public string? AddField10 { get; set; }
        public int? ExpirPeriod { get; set; }
        /// <summary>
        /// 1 day, 2 month, 3 year
        /// </summary>
        public byte? PeriodType { get; set; }
        /// <summary>
        /// 1 day, 2 month, 3 year
        /// </summary>
        [StringLength(255)]
        public string? OfferDesc { get; set; }
        public bool? InOffer { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? OfferFromDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? OfferToDate { get; set; }
        public bool? IsOfferDiscount { get; set; }
        public bool? IsDiscountPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Discount { get; set; }
        public bool? IsExpir { get; set; }
        public bool? IsAttributeItem { get; set; }
        public bool? IsCollection { get; set; }
        public bool? IsDimension { get; set; }
        public bool? IsSerialItem { get; set; }
        public bool? AllPatchesSamePrice { get; set; }
        public bool? UseSameItemAsMaterial { get; set; }
        public bool? AutoSuggestBatches { get; set; }
        public bool? CostWithDimension { get; set; }
        public byte? DimensionSalesPrice { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ItemLimit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ItemMax { get; set; }
        [StringLength(50)]
        public string? Length { get; set; }
        [StringLength(50)]
        public string? Width { get; set; }
        [StringLength(50)]
        public string? Height { get; set; }
        [StringLength(50)]
        public string? ItemSize { get; set; }
        [StringLength(50)]
        public string? ItemColor { get; set; }
        [StringLength(50)]
        public string? SerialNoPrefix { get; set; }
        public int? WarantyPeriod { get; set; }
        /// <summary>
        /// 1 day,2 week, 3 month, 4 year
        /// </summary>
        public byte? WarantyPeriodType { get; set; }
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
        public bool? IsTempItem { get; set; }
        public int? ProductionItemUnit { get; set; }
        public bool? SpecialItemExeclud { get; set; }
        public bool? IsCommisionPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Commision { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CommisionEndDate { get; set; }
        public bool? IsOuterItem { get; set; }
        public bool? UseSomeSubItems { get; set; }
        public bool? Unit2IsMandatory { get; set; }
        public bool? UseUnit2 { get; set; }
        public bool? IsSalesStopped { get; set; }
        public bool? IsServerEntity { get; set; }
        public int? MainServerId { get; set; }

        [ForeignKey("ItemCategoryId")]
        [InverseProperty("MsItemCards")]
        public virtual MsItemCategory? ItemCategory { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsDeliverItemCard> MsDeliverItemCards { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsItemAlternative> MsItemAlternatives { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsItemCardOffer> MsItemCardOffers { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsItemCollection> MsItemCollections { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsItemImage> MsItemImages { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsItemPartition> MsItemPartitions { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsItemStartQty> MsItemStartQties { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsItemStockAdjustmentDetail> MsItemStockAdjustmentDetails { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsItemUnit> MsItemUnits { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsItemVendor> MsItemVendors { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsPurchOrderDetail> MsPurchOrderDetails { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsPurchaseInvoiceItemCard> MsPurchaseInvoiceItemCards { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsReturnPurchaseItem> MsReturnPurchaseItems { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsReturnSalesItemCard> MsReturnSalesItemCards { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsSalesInvoiceItemCard> MsSalesInvoiceItemCards { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsSalesOfferItemCard> MsSalesOfferItemCards { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsStockReceiptItemCard> MsStockReceiptItemCards { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<MsStockTranItemCard> MsStockTranItemCards { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<ProdItemAttributsJoin> ProdItemAttributsJoins { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<ProdItemcardExpense> ProdItemcardExpenses { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<ProdJobOrderProduct> ProdJobOrderProducts { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<SrTaskItem> SrTaskItems { get; set; }
        [InverseProperty("ItemCard")]
        public virtual ICollection<SrVehicleItemCard> SrVehicleItemCards { get; set; }
    }
}
