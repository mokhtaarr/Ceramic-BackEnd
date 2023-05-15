using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_VheicleJobOrderType")]
    public partial class SrVheicleJobOrderType
    {
        public SrVheicleJobOrderType()
        {
            SrVehicleJobOrders = new HashSet<SrVehicleJobOrder>();
        }

        [Key]
        [Column("VOrderTypeId")]
        public int VorderTypeId { get; set; }
        public int? AccountId { get; set; }
        public int? AddAccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId2 { get; set; }
        [Column("VOrderTypeCode")]
        [StringLength(50)]
        public string? VorderTypeCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("IsANCOdeMandatory")]
        public bool? IsAncodeMandatory { get; set; }
        public bool? GetCustomerFromAn { get; set; }
        public bool? GetVendorFromAn { get; set; }
        public bool? GetItemFromAn { get; set; }
        public bool? IsCustomerMandatory { get; set; }
        [Column("GetCostCenterIdFromAN")]
        public bool? GetCostCenterIdFromAn { get; set; }
        [Column("GetAccountIdFromAN")]
        public bool? GetAccountIdFromAn { get; set; }
        public bool? IsDriverMandatory { get; set; }
        public int? BookId { get; set; }
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

        [InverseProperty("VorderType")]
        public virtual ICollection<SrVehicleJobOrder> SrVehicleJobOrders { get; set; }
    }
}
