using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sys_AnalyticalCodes")]
    public partial class SysAnalyticalCode
    {
        public SysAnalyticalCode()
        {
            CalAccountCharts = new HashSet<CalAccountChart>();
            CalJurnalEntries = new HashSet<CalJurnalEntry>();
            CodAccountCategories = new HashSet<CodAccountCategory>();
            CodDailyAssistances = new HashSet<CodDailyAssistance>();
            SysAnalyticalCodeProccesses = new HashSet<SysAnalyticalCodeProccess>();
            SysAnalyticalCodeUpdates = new HashSet<SysAnalyticalCodeUpdate>();
        }

        [Key]
        [Column("AId")]
        public int Aid { get; set; }
        [Column("ParentAId")]
        public int? ParentAid { get; set; }
        public int? CodeLevel { get; set; }
        public byte? CodeLevelType { get; set; }
        [StringLength(50)]
        public string Code { get; set; } = null!;
        [StringLength(100)]
        public string? DescA { get; set; }
        [StringLength(100)]
        public string? DescE { get; set; }
        public bool? Stopped { get; set; }
        public int? AccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? AssetId { get; set; }
        public int? EmpId { get; set; }
        [Column("BSPartnerId")]
        public int? BspartnerId { get; set; }
        public int? CustomerId { get; set; }
        public int? VendorId { get; set; }
        public int? ItemCardId { get; set; }
        [Column("AccomulatAId")]
        public int? AccomulatAid { get; set; }
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
        [StringLength(100)]
        public string? AddField11 { get; set; }
        [StringLength(100)]
        public string? AddField12 { get; set; }
        [StringLength(100)]
        public string? AddField13 { get; set; }
        [StringLength(100)]
        public string? AddField14 { get; set; }
        [StringLength(100)]
        public string? AddField15 { get; set; }
        [StringLength(100)]
        public string? AddField16 { get; set; }
        [StringLength(100)]
        public string? AddField17 { get; set; }
        [StringLength(100)]
        public string? AddField18 { get; set; }
        [StringLength(100)]
        public string? AddField19 { get; set; }
        [StringLength(100)]
        public string? AddField20 { get; set; }
        [StringLength(100)]
        public string? AddField21 { get; set; }
        [StringLength(100)]
        public string? AddField22 { get; set; }
        [StringLength(100)]
        public string? AddField23 { get; set; }
        [StringLength(100)]
        public string? AddField24 { get; set; }
        [StringLength(100)]
        public string? AddField25 { get; set; }
        [StringLength(100)]
        public string? AddField26 { get; set; }
        [StringLength(100)]
        public string? AddField27 { get; set; }
        [StringLength(100)]
        public string? AddField28 { get; set; }
        [StringLength(100)]
        public string? AddField29 { get; set; }
        [StringLength(100)]
        public string? AddField30 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AnDate1 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AnDate2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AnDate3 { get; set; }
        public bool? IsNotify1 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? NotifyDate1 { get; set; }
        public bool? IsNotify2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? NotifyDate2 { get; set; }
        public bool? IsNotify3 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? NotifyDate3 { get; set; }
        [StringLength(100)]
        public string? RemarksA { get; set; }
        [StringLength(100)]
        public string? RemarksE { get; set; }
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

        [InverseProperty("AidNavigation")]
        public virtual ICollection<CalAccountChart> CalAccountCharts { get; set; }
        [InverseProperty("AidNavigation")]
        public virtual ICollection<CalJurnalEntry> CalJurnalEntries { get; set; }
        [InverseProperty("AidNavigation")]
        public virtual ICollection<CodAccountCategory> CodAccountCategories { get; set; }
        [InverseProperty("AidNavigation")]
        public virtual ICollection<CodDailyAssistance> CodDailyAssistances { get; set; }
        [InverseProperty("AidNavigation")]
        public virtual ICollection<SysAnalyticalCodeProccess> SysAnalyticalCodeProccesses { get; set; }
        [InverseProperty("AidNavigation")]
        public virtual ICollection<SysAnalyticalCodeUpdate> SysAnalyticalCodeUpdates { get; set; }
    }
}
