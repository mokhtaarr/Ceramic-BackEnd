using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("WorkForc_PassPortsArchives")]
    public partial class WorkForcPassPortsArchive
    {
        [Key]
        [Column("WFPassPortArchId")]
        public int WfpassPortArchId { get; set; }
        [Column("WFPassPortId")]
        public int WfpassPortId { get; set; }
        public int? StoreId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
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
        public string? Name5en { get; set; }
        [StringLength(50)]
        public string? Name6en { get; set; }
        [StringLength(50)]
        public string? Name7en { get; set; }
        [StringLength(200)]
        public string? FullNameen { get; set; }
        public int? CustomerId { get; set; }
        public int? JobId { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(50)]
        public string? PassOwnerId { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        public int? SeasonId { get; set; }
        public bool? Gender { get; set; }
        /// <summary>
        /// 0 single,1 married,2 married and have kids
        /// </summary>
        public byte? MaritalStatus { get; set; }
        public byte? KidsNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }
        [Column("IDIssueDate", TypeName = "smalldatetime")]
        public DateTime? IdissueDate { get; set; }
        [Column("IDExpiryDate", TypeName = "smalldatetime")]
        public DateTime? IdexpiryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PassportIssueDate { get; set; }
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
        public bool? Execluded { get; set; }
    }
}
