using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjUnits")]
    public partial class ProjProjUnit
    {
        public ProjProjUnit()
        {
            ProjProjInsuranceUnits = new HashSet<ProjProjInsuranceUnit>();
            ProjProjUnitDocuments = new HashSet<ProjProjUnitDocument>();
            ProjProjUnitExploitJoins = new HashSet<ProjProjUnitExploitJoin>();
            ProjProjUnitInstallTemps = new HashSet<ProjProjUnitInstallTemp>();
            ProjProjUnitOccupTypeJoins = new HashSet<ProjProjUnitOccupTypeJoin>();
            ProjProjUnitOwnerJoins = new HashSet<ProjProjUnitOwnerJoin>();
            ProjProjUnitPermitActivityJoins = new HashSet<ProjProjUnitPermitActivityJoin>();
            ProjProjUnitPerspectiveJoins = new HashSet<ProjProjUnitPerspectiveJoin>();
            ProjProjUnitPictures = new HashSet<ProjProjUnitPicture>();
            ProjProjUnitServices = new HashSet<ProjProjUnitService>();
            ProjProjUnitSubUnits = new HashSet<ProjProjUnitSubUnit>();
        }

        [Key]
        public int ProjUnitId { get; set; }
        public int? ProjectId { get; set; }
        public int? UnittypeId { get; set; }
        public int? UnitStatId { get; set; }
        public int? UnitDegreeId { get; set; }
        public int? UnFinLevelId { get; set; }
        public int? UnitInsurstatId { get; set; }
        public int? ParkingId { get; set; }
        public int? ContractTypeId { get; set; }
        public int? RentCaseId { get; set; }
        public int? TermId { get; set; }
        public int? CurrencyId { get; set; }
        [StringLength(100)]
        public string? Code { get; set; }
        [StringLength(200)]
        public string? Name1 { get; set; }
        [StringLength(200)]
        public string? Name2 { get; set; }
        public int? RoomCount { get; set; }
        public int? FloorNumber { get; set; }
        public long? WaterCounter { get; set; }
        public long? ElectricityCounter { get; set; }
        public bool? CalcAllMeters { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BuildingArea { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BuildingMeterPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitArea { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitMeterPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EstimatedUnitArea { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrice { get; set; }
        public bool? CommissionIsPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CommissionValue { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpectedDeliveryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UnitStartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UnitExpectedStartDate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ParkArea { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ParkMeterPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RoofArea { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RoofMeterPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? GardenArea { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? GardenMeterPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BaseMentArea { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BasementMeterPrice { get; set; }
        public bool? CanSaleUnits { get; set; }
        public bool? CanRentUnits { get; set; }
        public bool? ProjectStopped { get; set; }
        public bool? Sold { get; set; }
        [StringLength(50)]
        public string? ContractDocNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ContractDate { get; set; }
        public bool? Reserved { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReserveDate { get; set; }
        [StringLength(50)]
        public string? ReserveDocNo { get; set; }
        public bool? Rented { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RentDate { get; set; }
        [StringLength(50)]
        public string? RentDocNo { get; set; }
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
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        public byte? MaxRents { get; set; }

        [ForeignKey("ProjectId")]
        [InverseProperty("ProjProjUnits")]
        public virtual ProjProject? Project { get; set; }
        [InverseProperty("ProjUnit")]
        public virtual ICollection<ProjProjInsuranceUnit> ProjProjInsuranceUnits { get; set; }
        [InverseProperty("ProjUnit")]
        public virtual ICollection<ProjProjUnitDocument> ProjProjUnitDocuments { get; set; }
        [InverseProperty("ProjUnit")]
        public virtual ICollection<ProjProjUnitExploitJoin> ProjProjUnitExploitJoins { get; set; }
        [InverseProperty("ProjUnit")]
        public virtual ICollection<ProjProjUnitInstallTemp> ProjProjUnitInstallTemps { get; set; }
        [InverseProperty("ProjUnit")]
        public virtual ICollection<ProjProjUnitOccupTypeJoin> ProjProjUnitOccupTypeJoins { get; set; }
        [InverseProperty("ProjUnit")]
        public virtual ICollection<ProjProjUnitOwnerJoin> ProjProjUnitOwnerJoins { get; set; }
        [InverseProperty("ProjUnit")]
        public virtual ICollection<ProjProjUnitPermitActivityJoin> ProjProjUnitPermitActivityJoins { get; set; }
        [InverseProperty("ProjUnit")]
        public virtual ICollection<ProjProjUnitPerspectiveJoin> ProjProjUnitPerspectiveJoins { get; set; }
        [InverseProperty("ProjUnit")]
        public virtual ICollection<ProjProjUnitPicture> ProjProjUnitPictures { get; set; }
        [InverseProperty("ProjUnit")]
        public virtual ICollection<ProjProjUnitService> ProjProjUnitServices { get; set; }
        [InverseProperty("ProjUnit")]
        public virtual ICollection<ProjProjUnitSubUnit> ProjProjUnitSubUnits { get; set; }
    }
}
