using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_Projects")]
    public partial class ProjProject
    {
        public ProjProject()
        {
            ProjAccounts = new HashSet<ProjAccount>();
            ProjEstimateItems = new HashSet<ProjEstimateItem>();
            ProjExpenses = new HashSet<ProjExpense>();
            ProjFunds = new HashSet<ProjFund>();
            ProjProjDocuments = new HashSet<ProjProjDocument>();
            ProjProjExploitJoins = new HashSet<ProjProjExploitJoin>();
            ProjProjInsurances = new HashSet<ProjProjInsurance>();
            ProjProjOccupTypeJoins = new HashSet<ProjProjOccupTypeJoin>();
            ProjProjOwnerJoins = new HashSet<ProjProjOwnerJoin>();
            ProjProjParkingJoins = new HashSet<ProjProjParkingJoin>();
            ProjProjPermitActivityJoins = new HashSet<ProjProjPermitActivityJoin>();
            ProjProjPerspectiveJoins = new HashSet<ProjProjPerspectiveJoin>();
            ProjProjPictures = new HashSet<ProjProjPicture>();
            ProjProjUnits = new HashSet<ProjProjUnit>();
            ProjProjectItemsJoins = new HashSet<ProjProjectItemsJoin>();
            ProjRealItems = new HashSet<ProjRealItem>();
        }

        [Key]
        public int ProjectId { get; set; }
        public int? BuildTypeId { get; set; }
        public int? BuildStatusId { get; set; }
        public int? BuildDegreeId { get; set; }
        public int? BuildFinishLevelId { get; set; }
        public int? LandId { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public int? RegionId { get; set; }
        public int? SubRegionClassId { get; set; }
        public int? ContractTypeId { get; set; }
        public int? PostalCodId { get; set; }
        public int? RentCaseId { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? CostCenterId3 { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? CurrencyId { get; set; }
        [StringLength(50)]
        public string? ProjectCode { get; set; }
        [StringLength(100)]
        public string? ProjectName1 { get; set; }
        [StringLength(100)]
        public string? ProjectName2 { get; set; }
        [StringLength(250)]
        public string? Description1 { get; set; }
        [StringLength(250)]
        public string? Description2 { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        public int? ParentProjectId { get; set; }
        public bool? ProjectStopped { get; set; }
        public int? ProjectStoppedbyUserId { get; set; }
        public bool? CalcAllMeters { get; set; }
        public bool? CanSaleUnits { get; set; }
        public bool? CanRentUnits { get; set; }
        [StringLength(200)]
        public string? StreetNo { get; set; }
        [StringLength(200)]
        public string? LandNo { get; set; }
        public int? FloorsCount { get; set; }
        public int? FloorUnitCount { get; set; }
        public int? FirstFloorUnitCount { get; set; }
        public int? LastFloorUnitCount { get; set; }
        public long? WaterCounter { get; set; }
        public long? ElectricityCounter { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Landarea { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BuildingArea { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? LandMeterPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? BuildingMeterPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrice { get; set; }
        [StringLength(300)]
        public string? NorthBoundary { get; set; }
        [StringLength(300)]
        public string? SouthBoundary { get; set; }
        [StringLength(300)]
        public string? WestBoundary { get; set; }
        [StringLength(300)]
        public string? EastBoundary { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpectedDeliveryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ContractDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ProjectStartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ProjectExpectedStartDate { get; set; }
        public byte? FundSource { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidCapital { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ProjectValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? PaidCapitalPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ExpectedExpense { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ActualExpense { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ActualExpensePercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RemainExpense { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RemainExpensePercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CompanySharePercent { get; set; }
        public bool? CommissionIsPercent { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CommissionValue { get; set; }
        public int? ProjectManagerId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CompanyShare { get; set; }
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

        [InverseProperty("Project")]
        public virtual ICollection<ProjAccount> ProjAccounts { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjEstimateItem> ProjEstimateItems { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjExpense> ProjExpenses { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjFund> ProjFunds { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjProjDocument> ProjProjDocuments { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjProjExploitJoin> ProjProjExploitJoins { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjProjInsurance> ProjProjInsurances { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjProjOccupTypeJoin> ProjProjOccupTypeJoins { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjProjOwnerJoin> ProjProjOwnerJoins { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjProjParkingJoin> ProjProjParkingJoins { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjProjPermitActivityJoin> ProjProjPermitActivityJoins { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjProjPerspectiveJoin> ProjProjPerspectiveJoins { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjProjPicture> ProjProjPictures { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjProjUnit> ProjProjUnits { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjProjectItemsJoin> ProjProjectItemsJoins { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<ProjRealItem> ProjRealItems { get; set; }
    }
}
