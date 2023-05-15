using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class SearchPassPort
    {
        [Column("WFPassPortId")]
        public int WfpassPortId { get; set; }
        [StringLength(50)]
        public string Code { get; set; } = null!;
        [StringLength(50)]
        public string PassportNo { get; set; } = null!;
        [StringLength(50)]
        public string? Name1 { get; set; }
        [StringLength(50)]
        public string? Name2 { get; set; }
        [StringLength(50)]
        public string? Name3 { get; set; }
        [StringLength(50)]
        public string? Name4 { get; set; }
        [StringLength(50)]
        public string? Name5 { get; set; }
        [StringLength(50)]
        public string? Name6 { get; set; }
        [StringLength(50)]
        public string? Name7 { get; set; }
        [StringLength(200)]
        public string? FullName { get; set; }
        [StringLength(50)]
        public string? Nameen { get; set; }
        [StringLength(50)]
        public string? Name2en { get; set; }
        [StringLength(50)]
        public string? Name3en { get; set; }
        [StringLength(50)]
        public string? Name4en { get; set; }
        [StringLength(50)]
        public string? Name6en { get; set; }
        [StringLength(50)]
        public string? Name7en { get; set; }
        [StringLength(200)]
        public string? FullNameen { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(50)]
        public string? PassOwnerId { get; set; }
        public bool? Gender { get; set; }
        public byte? MaritalStatus { get; set; }
        public byte? KidsNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }
        [Column("IDIssueDate", TypeName = "smalldatetime")]
        public DateTime? IdissueDate { get; set; }
        [Column("IDExpiryDate", TypeName = "smalldatetime")]
        public DateTime? IdexpiryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PassportExpiryDate { get; set; }
        [StringLength(100)]
        public string? PassportIssuePlace { get; set; }
        [StringLength(20)]
        public string? Phone1 { get; set; }
        [StringLength(20)]
        public string? Phone2 { get; set; }
        [StringLength(20)]
        public string? Phone3 { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(200)]
        public string? Address1 { get; set; }
        [StringLength(200)]
        public string? Address2 { get; set; }
        public byte? MilitaryService { get; set; }
        [Column("IDmage1")]
        [StringLength(300)]
        public string? Idmage1 { get; set; }
        [StringLength(300)]
        public string? PassPortImage { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        public bool Execluded { get; set; }
        [Column("JCode")]
        [StringLength(50)]
        public string? Jcode { get; set; }
        [Column("JName1")]
        [StringLength(100)]
        public string? Jname1 { get; set; }
        public bool TestMandatory { get; set; }
        [StringLength(50)]
        public string? CompCode { get; set; }
        [StringLength(100)]
        public string? FirmName { get; set; }
        [StringLength(100)]
        public string? FirmOwnerName { get; set; }
        [StringLength(100)]
        public string? TaxRefNo { get; set; }
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(100)]
        public string? CustomerDescE { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(50)]
        public string? SeasonCode { get; set; }
        [StringLength(100)]
        public string? SeasonName1 { get; set; }
        [StringLength(100)]
        public string? SeasonName2 { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EmbassyDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AcceptAgeFrom { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AcceptAgeTo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PassPortExpiry { get; set; }
        [StringLength(50)]
        public string? CityCode { get; set; }
        [StringLength(100)]
        public string? CityName { get; set; }
        public int? CustSerial { get; set; }
        public int? SeasonId { get; set; }
    }
}
