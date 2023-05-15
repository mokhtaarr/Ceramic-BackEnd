using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_EmpJobOrderDistribDetail")]
    public partial class ProdEmpJobOrderDistribDetail
    {
        [Key]
        public int EmpJobOrderDistDetailId { get; set; }
        public int? EmpJobOrderDistId { get; set; }
        public int? EquipId { get; set; }
        public int? EmpId { get; set; }
        public int? JobOrderId { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }

        [ForeignKey("EmpJobOrderDistId")]
        [InverseProperty("ProdEmpJobOrderDistribDetails")]
        public virtual ProdEmpJobOrderDistrib? EmpJobOrderDist { get; set; }
    }
}
