using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_DeliverItemCard")]
    public partial class MsDeliverItemCard
    {
        public MsDeliverItemCard()
        {
            MsItemSerials = new HashSet<MsItemSerial>();
        }

        [Key]
        public int DelivItemCardId { get; set; }
        public int? DeliverId { get; set; }
        public int? RetPurchItemCardId { get; set; }
        public int? InvItemCardId { get; set; }
        public int? SalesOrdertemCardId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        [Column("jobMaterialId")]
        public int? JobMaterialId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? FollowCollectionId { get; set; }
        public int? ItemIdToFollow { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? ScaleCardId { get; set; }
        public int? UnitId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitRate { get; set; }
        public int? BillOfMaterialId { get; set; }
        public byte? ItemType { get; set; }
        [StringLength(60)]
        public string? BarCode { get; set; }
        [StringLength(20)]
        public string? BatchNumberFifoOrLifo { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QuantityOut { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyOutBeforRate { get; set; }
        [Column("QtyIUnit2", TypeName = "numeric(38, 10)")]
        public decimal? QtyIunit2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QtyBeforRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ServicePrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProfitPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Kirat { get; set; }
        public bool? IsBonus { get; set; }
        public bool? IsCollection { get; set; }
        [Column("FIFOCost", TypeName = "numeric(38, 10)")]
        public decimal? Fifocost { get; set; }
        [Column("FIFOCostUnit", TypeName = "numeric(38, 10)")]
        public decimal? FifocostUnit { get; set; }
        [Column("LIFOCost", TypeName = "numeric(38, 10)")]
        public decimal? Lifocost { get; set; }
        [Column("LIFOCostUnit", TypeName = "numeric(38, 10)")]
        public decimal? LifocostUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverage { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CoastAverageUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCost { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LastCostUnit { get; set; }
        public byte? Satus { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenseShare { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenseShareUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterExpense { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterExpenseUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterCurrUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenseShareAfterCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpenseShareAfterCurrUnit { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterExpenseAfterCurr { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PriceAfterExpensAfterCurrUnit { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(100)]
        public string? Remarks3 { get; set; }
        [StringLength(100)]
        public string? ItemCardDesc { get; set; }
        [StringLength(100)]
        public string? ItemCardDescE { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [Column("DBTableName")]
        [StringLength(100)]
        public string? DbtableName { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [Column("DBTableId")]
        public int? DbtableId { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [StringLength(100)]
        public string? AccountTableName { get; set; }
        public byte? RectSourceType { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? AccountId { get; set; }
        public int? RectSourceTypeId { get; set; }
        public int? VehicleId1 { get; set; }
        public int? VehicleId2 { get; set; }
        [StringLength(100)]
        public string? DriverName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeEnd { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public int? MainServerId { get; set; }
        public int? ServerUnitId { get; set; }
        public int? ServerItemCardId { get; set; }

        [ForeignKey("DeliverId")]
        [InverseProperty("MsDeliverItemCards")]
        public virtual MsDeliverSalesInvoice? Deliver { get; set; }
        [ForeignKey("ItemCardId")]
        [InverseProperty("MsDeliverItemCards")]
        public virtual MsItemCard? ItemCard { get; set; }
        [ForeignKey("UnitId")]
        [InverseProperty("MsDeliverItemCards")]
        public virtual MsItemUnit? Unit { get; set; }
        [InverseProperty("DelivItemCard")]
        public virtual ICollection<MsItemSerial> MsItemSerials { get; set; }
    }
}
