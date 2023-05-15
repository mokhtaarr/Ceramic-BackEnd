using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchServiceRequest
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [StringLength(100)]
        public string? SerialNo1 { get; set; }
        [StringLength(100)]
        public string? SerialNo2 { get; set; }
        [StringLength(200)]
        public string? CloseReason { get; set; }
        [StringLength(50)]
        public string? ModelNo { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QoutationPrice { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? VistitDate { get; set; }
        public bool? InWarranty { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? WarrantyEndDate { get; set; }
        public byte? RequestStatus { get; set; }
        [StringLength(200)]
        public string? AddField1 { get; set; }
        [StringLength(200)]
        public string? AddField2 { get; set; }
        [StringLength(200)]
        public string? AddField3 { get; set; }
        [StringLength(200)]
        public string? AddField4 { get; set; }
        [StringLength(200)]
        public string? AddField5 { get; set; }
        [StringLength(200)]
        public string? AddField6 { get; set; }
        [StringLength(200)]
        public string? AddField7 { get; set; }
        [StringLength(200)]
        public string? AddField8 { get; set; }
        [StringLength(200)]
        public string? AddField9 { get; set; }
        [StringLength(200)]
        public string? AddField10 { get; set; }
        [StringLength(50)]
        public string? StoreCode { get; set; }
        [StringLength(100)]
        public string? StoreDescA { get; set; }
        [StringLength(100)]
        public string? StoreDescE { get; set; }
        public int? BookId { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(100)]
        public string? CustomerDescE { get; set; }
        [StringLength(50)]
        public string? AnalyticalCode { get; set; }
        public int? CodeLevel { get; set; }
        public byte? CodeLevelType { get; set; }
        [StringLength(100)]
        public string? AnalyticalCodeName1 { get; set; }
        [StringLength(100)]
        public string? AnalyticalCodeName2 { get; set; }
        public bool? Stopped { get; set; }
        [StringLength(100)]
        public string? CityName { get; set; }
        [StringLength(100)]
        public string? CountryName { get; set; }
        [Column("WName1")]
        [StringLength(100)]
        public string? Wname1 { get; set; }
        public byte? ExemptionPercnt { get; set; }
        [StringLength(100)]
        public string? CapcityDescA { get; set; }
        [StringLength(50)]
        public string? Size { get; set; }
        [StringLength(100)]
        public string? BrandName { get; set; }
        [StringLength(100)]
        public string? ProductsTypeName { get; set; }
        [StringLength(100)]
        public string? ReqResourceName { get; set; }
        [StringLength(100)]
        public string? MaintenanceTypeName { get; set; }
        [StringLength(100)]
        public string? ItemDescA { get; set; }
        [StringLength(100)]
        public string? RegionNameA { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(20)]
        public string? Tel2 { get; set; }
        [StringLength(20)]
        public string? Tel3 { get; set; }
        [StringLength(20)]
        public string? Tel4 { get; set; }
    }
}
