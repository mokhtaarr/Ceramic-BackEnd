using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchReqOfQoutation
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [StringLength(150)]
        public string? Shipper { get; set; }
        [StringLength(200)]
        public string? PortOfLoading { get; set; }
        [StringLength(200)]
        public string? PortOfDischarge { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Commodity { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Equipment { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TargetRate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Recommendation { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TruckingFrom { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TruckingTo { get; set; }
        [StringLength(2000)]
        public string? Remarks { get; set; }
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
    }
}
