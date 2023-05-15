using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_Reciption")]
    public partial class SrReciption
    {
        public SrReciption()
        {
            SrJobOrders = new HashSet<SrJobOrder>();
            SrReceptionImages = new HashSet<SrReceptionImage>();
            SrReciptionDetails = new HashSet<SrReciptionDetail>();
        }

        [Key]
        public int ReciptionId { get; set; }
        public int? StoreId { get; set; }
        public int? TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        public int? CustId { get; set; }
        public int? ItemCardId { get; set; }
        [Column("VID")]
        public int? Vid { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? MileAge { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        [StringLength(500)]
        public string? Remarks { get; set; }
        public int? RecevedBy { get; set; }
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

        [InverseProperty("Reciption")]
        public virtual ICollection<SrJobOrder> SrJobOrders { get; set; }
        [InverseProperty("Reciption")]
        public virtual ICollection<SrReceptionImage> SrReceptionImages { get; set; }
        [InverseProperty("Reciption")]
        public virtual ICollection<SrReciptionDetail> SrReciptionDetails { get; set; }
    }
}
