using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwWeightCard
    {
        public int ScaleCardId { get; set; }
        public int TrNo { get; set; }
        public byte? SourceType { get; set; }
        public int? SourceId { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        public bool? InOrOut { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeightQty1 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeightQty2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? WeightQtyDiff { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Weight1Date { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Weight2Date { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Weight1Time { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Weight2Time { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
        [StringLength(500)]
        public string? Remarks1 { get; set; }
        [StringLength(500)]
        public string? Remarks2 { get; set; }
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(50)]
        public string? EmpCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(50)]
        public string? DriverCode { get; set; }
        [StringLength(100)]
        public string? DriverName1 { get; set; }
        [StringLength(100)]
        public string? VehicleCode { get; set; }
        [StringLength(100)]
        public string? VehicleName1 { get; set; }
        [Column("empcode2")]
        [StringLength(50)]
        public string? Empcode2 { get; set; }
        [Column("addemp1")]
        [StringLength(100)]
        public string? Addemp1 { get; set; }
        [Column("addemp2")]
        [StringLength(100)]
        public string? Addemp2 { get; set; }
        [StringLength(50)]
        public string? StoreCode { get; set; }
        [StringLength(100)]
        public string? StoreDescA { get; set; }
        [StringLength(50)]
        public string? PartCode { get; set; }
        [StringLength(100)]
        public string? PartDescA { get; set; }
        [StringLength(100)]
        public string? CityName { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(100)]
        public string? RegNo { get; set; }
        [StringLength(100)]
        public string? BodyNo { get; set; }
        [StringLength(100)]
        public string? MotorNo { get; set; }
        [StringLength(255)]
        public string? VehiclRemarks { get; set; }
        public bool? Closed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        public int? ClosedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UncloseDate { get; set; }
        public int? UnclosedBy { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
    }
}
