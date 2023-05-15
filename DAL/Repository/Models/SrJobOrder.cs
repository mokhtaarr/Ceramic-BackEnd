using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_JobOrder")]
    public partial class SrJobOrder
    {
        public SrJobOrder()
        {
            SrJobAdditionalCosts = new HashSet<SrJobAdditionalCost>();
            SrJobComments = new HashSet<SrJobComment>();
            SrJobExtrnalExpens = new HashSet<SrJobExtrnalExpen>();
            SrJobFiles = new HashSet<SrJobFile>();
            SrJobSparts = new HashSet<SrJobSpart>();
            SrJobSwages = new HashSet<SrJobSwage>();
        }

        [Key]
        public int JorderId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column("SrTypID")]
        public int? SrTypId { get; set; }
        public int? ReciptionId { get; set; }
        public int? CustId { get; set; }
        public int? VehicleId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? AccountId { get; set; }
        public int? AddAccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId2 { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public int? CurrencyId { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? SparePrts { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Wages { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Expense { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? OtherCosts { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? NetValue { get; set; }
        public bool? CustSatisfy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExitDate { get; set; }
        public int? ApprovedBy { get; set; }
        public bool? FreeService { get; set; }
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

        [ForeignKey("ReciptionId")]
        [InverseProperty("SrJobOrders")]
        public virtual SrReciption? Reciption { get; set; }
        [ForeignKey("SrTypId")]
        [InverseProperty("SrJobOrders")]
        public virtual SrServiceType? SrTyp { get; set; }
        [ForeignKey("VehicleId")]
        [InverseProperty("SrJobOrders")]
        public virtual SrVehicle? Vehicle { get; set; }
        [InverseProperty("Jorder")]
        public virtual ICollection<SrJobAdditionalCost> SrJobAdditionalCosts { get; set; }
        [InverseProperty("Jorder")]
        public virtual ICollection<SrJobComment> SrJobComments { get; set; }
        [InverseProperty("Jorder")]
        public virtual ICollection<SrJobExtrnalExpen> SrJobExtrnalExpens { get; set; }
        [InverseProperty("Jorder")]
        public virtual ICollection<SrJobFile> SrJobFiles { get; set; }
        [InverseProperty("Jorder")]
        public virtual ICollection<SrJobSpart> SrJobSparts { get; set; }
        [InverseProperty("Jorder")]
        public virtual ICollection<SrJobSwage> SrJobSwages { get; set; }
    }
}
