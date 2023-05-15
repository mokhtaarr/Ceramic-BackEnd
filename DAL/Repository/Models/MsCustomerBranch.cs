using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_CustomerBranches")]
    public partial class MsCustomerBranch
    {
        [Key]
        public int CustBranchId { get; set; }
        public int? CustomerId { get; set; }
        [StringLength(50)]
        public string? CustBranchCode { get; set; }
        [StringLength(100)]
        public string? CustBranchName1 { get; set; }
        [StringLength(100)]
        public string? CustBranchName2 { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        [StringLength(250)]
        public string? Address { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("MsCustomerBranches")]
        public virtual MsCustomer? Customer { get; set; }
    }
}
