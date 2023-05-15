using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_ShippingDeclaration")]
    public partial class SrShippingDeclaration
    {
        [Key]
        public int ShipDeclarId { get; set; }
        public int? RoqId { get; set; }
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
        public int? ValidityDays { get; set; }
        [StringLength(150)]
        public string? Shipper { get; set; }
        [StringLength(150)]
        public string? Consignee { get; set; }
        [StringLength(150)]
        public string? VesselName { get; set; }
        [StringLength(200)]
        public string? PortOfLoading { get; set; }
        [StringLength(200)]
        public string? PortOfDischarge { get; set; }
        [StringLength(200)]
        public string? FreightPayableAt { get; set; }
        [StringLength(200)]
        public string? BillOfLading { get; set; }
        [StringLength(2000)]
        public string? Notify { get; set; }
        [StringLength(2000)]
        public string? MarksAndNumbers { get; set; }
        [StringLength(2000)]
        public string? Remarks { get; set; }
        [Column("ContainersDRY")]
        [StringLength(200)]
        public string? ContainersDry { get; set; }
        [StringLength(200)]
        public string? NetWeightTons { get; set; }
        [StringLength(200)]
        public string? GrossWeightTons { get; set; }
        [StringLength(200)]
        public string? AddField1 { get; set; }
        [StringLength(200)]
        public string? AddField2 { get; set; }
        [StringLength(200)]
        public string? AddField3 { get; set; }
        [StringLength(200)]
        public string? AddField4 { get; set; }
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
    }
}
