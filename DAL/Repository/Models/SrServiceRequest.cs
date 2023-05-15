using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_ServiceRequest")]
    public partial class SrServiceRequest
    {
        [Key]
        public int SerReqId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? CustomerId { get; set; }
        public int? ItemCardId { get; set; }
        /// <summary>
        /// 1 Good,2 Weak, Perfect 3
        /// </summary>
        public byte? ItemStatus { get; set; }
        public int? BrandId { get; set; }
        public int? ProductTypeId { get; set; }
        public int? ReqResourcId { get; set; }
        public int? MaintainTypeId { get; set; }
        public int? CapcityId { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        public int? RegionId { get; set; }
        [Column("WId")]
        public int? Wid { get; set; }
        [StringLength(100)]
        public string? SerialNo1 { get; set; }
        [StringLength(100)]
        public string? SerialNo2 { get; set; }
        [StringLength(50)]
        public string? ModelNo { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        [StringLength(2000)]
        public string? Complain { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QoutationPrice { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? VistitDate { get; set; }
        public bool? InWarranty { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? WarrantyEndDate { get; set; }
        /// <summary>
        /// 1 opened,2 closed
        /// </summary>
        public byte? RequestStatus { get; set; }
        [StringLength(200)]
        public string? CloseReason { get; set; }
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
    }
}
