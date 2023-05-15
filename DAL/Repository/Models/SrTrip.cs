using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_Trips")]
    public partial class SrTrip
    {
        public SrTrip()
        {
            SrAccomodations = new HashSet<SrAccomodation>();
            SrExtensions = new HashSet<SrExtension>();
            SrFlights = new HashSet<SrFlight>();
            SrTransportations = new HashSet<SrTransportation>();
            SrTripProgramJoins = new HashSet<SrTripProgramJoin>();
        }

        [Key]
        public int TripId { get; set; }
        public int? StoreId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        public int? TourGuideEmpId { get; set; }
        public int? TourLeaderEmpId { get; set; }
        [StringLength(100)]
        public string? TourGuideName { get; set; }
        [StringLength(100)]
        public string? TourLeaderName { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
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
        public int? ApprovedByEmpId { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        public bool? Guid { get; set; }
        public bool? Visa { get; set; }
        [StringLength(255)]
        public string? Others { get; set; }
        public byte? PersonsCount { get; set; }
        [StringLength(100)]
        public string? Agent { get; set; }
        [StringLength(100)]
        public string? Program { get; set; }
        [StringLength(100)]
        public string? Names { get; set; }
        [StringLength(100)]
        public string? OperatorName { get; set; }
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
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
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

        [InverseProperty("Trip")]
        public virtual ICollection<SrAccomodation> SrAccomodations { get; set; }
        [InverseProperty("Trip")]
        public virtual ICollection<SrExtension> SrExtensions { get; set; }
        [InverseProperty("Trip")]
        public virtual ICollection<SrFlight> SrFlights { get; set; }
        [InverseProperty("Trip")]
        public virtual ICollection<SrTransportation> SrTransportations { get; set; }
        [InverseProperty("Trip")]
        public virtual ICollection<SrTripProgramJoin> SrTripProgramJoins { get; set; }
    }
}
