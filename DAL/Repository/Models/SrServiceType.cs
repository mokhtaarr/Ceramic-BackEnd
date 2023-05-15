using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_ServiceTypes")]
    public partial class SrServiceType
    {
        public SrServiceType()
        {
            SrEmpServicTypes = new HashSet<SrEmpServicType>();
            SrJobOrders = new HashSet<SrJobOrder>();
        }

        [Key]
        [Column("SrTypID")]
        public int SrTypId { get; set; }
        [StringLength(50)]
        public string? SrCode { get; set; }
        [StringLength(100)]
        public string? SrName1 { get; set; }
        [StringLength(100)]
        public string? SrName2 { get; set; }
        [StringLength(500)]
        public string? SrDesc { get; set; }
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

        [InverseProperty("SrTyp")]
        public virtual ICollection<SrEmpServicType> SrEmpServicTypes { get; set; }
        [InverseProperty("SrTyp")]
        public virtual ICollection<SrJobOrder> SrJobOrders { get; set; }
    }
}
