using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchTrip
    {
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [StringLength(100)]
        public string? TourGuideName { get; set; }
        [StringLength(100)]
        public string? TourLeaderName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ArrivalDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ArrivalTime { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeparturDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeparturTime { get; set; }
        [StringLength(100)]
        public string? ArrivedBy { get; set; }
        [StringLength(100)]
        public string? DepartureBy { get; set; }
        public bool? Approver { get; set; }
        [StringLength(100)]
        public string? ApprovedBy { get; set; }
        public bool? Guid { get; set; }
        public bool? Visa { get; set; }
        [StringLength(255)]
        public string? Others { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(20)]
        public string? Fax { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Email2 { get; set; }
        [StringLength(50)]
        public string? Email3 { get; set; }
        [StringLength(50)]
        public string? Email4 { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        [StringLength(200)]
        public string? Address1 { get; set; }
        [StringLength(200)]
        public string? Address2 { get; set; }
        [StringLength(200)]
        public string? Address3 { get; set; }
        [StringLength(20)]
        public string? Tel2 { get; set; }
        [StringLength(20)]
        public string? Tel3 { get; set; }
        [StringLength(20)]
        public string? Tel4 { get; set; }
        [StringLength(20)]
        public string? Tel5 { get; set; }
        [StringLength(255)]
        public string? AddField1 { get; set; }
        [StringLength(255)]
        public string? AddField2 { get; set; }
        [StringLength(255)]
        public string? AddField3 { get; set; }
        [StringLength(255)]
        public string? AddField4 { get; set; }
        [StringLength(255)]
        public string? AddField5 { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [StringLength(50)]
        public string? CityCode { get; set; }
        [StringLength(100)]
        public string? CityName { get; set; }
        public byte? PersonsCount { get; set; }
        [StringLength(100)]
        public string? Agent { get; set; }
        [StringLength(100)]
        public string? Program { get; set; }
        [StringLength(100)]
        public string? Names { get; set; }
        [StringLength(100)]
        public string? OperatorName { get; set; }
        public int? BookId { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
    }
}
