using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_WeightCard")]
    public partial class MsWeightCard
    {
        public MsWeightCard()
        {
            MsWeightcardItems = new HashSet<MsWeightcardItem>();
        }

        [Key]
        public int ScaleCardId { get; set; }
        public int? SourceId { get; set; }
        public byte? SourceType { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? EquipId { get; set; }
        public int? DriverId { get; set; }
        public int? EmpId1 { get; set; }
        public int? EmpId2 { get; set; }
        public int? VehicleId { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeightQty1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeightQty2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WheightDiscPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeightQtyDiscount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeightQtyDiff { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Weight1Date { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Weight1Time { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Weight2Date { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Weight2Time { get; set; }
        public bool? InOrOut { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
        [StringLength(500)]
        public string? Remarks1 { get; set; }
        [StringLength(500)]
        public string? Remarks2 { get; set; }
        [StringLength(50)]
        public string? ClosingDoc { get; set; }
        public int? ClosingDocId { get; set; }
        public bool? IsPrinted { get; set; }
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
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
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

        [InverseProperty("ScaleCard")]
        public virtual ICollection<MsWeightcardItem> MsWeightcardItems { get; set; }
    }
}
