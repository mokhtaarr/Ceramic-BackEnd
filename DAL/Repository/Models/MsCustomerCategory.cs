using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_CustomerCategory")]
    public partial class MsCustomerCategory
    {
        public MsCustomerCategory()
        {
            MsCustomers = new HashSet<MsCustomer>();
        }

        [Key]
        public int CustomerCatId { get; set; }
        [StringLength(50)]
        public string CatCode { get; set; } = null!;
        [StringLength(100)]
        public string? CatDescA { get; set; }
        [StringLength(100)]
        public string? CatDescE { get; set; }
        public int? ParentCustomerCatId { get; set; }
        public int? CustomerCatParent { get; set; }
        public int? CustomerCatLevel { get; set; }
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

        [InverseProperty("CustomerCat")]
        public virtual ICollection<MsCustomer> MsCustomers { get; set; }
    }
}
