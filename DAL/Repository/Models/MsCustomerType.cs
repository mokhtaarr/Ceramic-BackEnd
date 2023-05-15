using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_CustomerTypes")]
    public partial class MsCustomerType
    {
        public MsCustomerType()
        {
            MsCustomers = new HashSet<MsCustomer>();
        }

        [Key]
        public int CustomerTypeId { get; set; }
        [StringLength(50)]
        public string CustomerTypeCode { get; set; } = null!;
        [StringLength(100)]
        public string? CustomerTypeDescA { get; set; }
        [StringLength(100)]
        public string? CustomerTypeDescE { get; set; }
        public int? CustomerTypeParent { get; set; }
        public int? CustomerTypeLevel { get; set; }
        public byte? CustomerTypeLevelType { get; set; }
        public int? CurrentTrNo { get; set; }
        [StringLength(100)]
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

        [InverseProperty("CustomerType")]
        public virtual ICollection<MsCustomer> MsCustomers { get; set; }
    }
}
