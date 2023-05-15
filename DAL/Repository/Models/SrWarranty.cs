using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_Warranty")]
    public partial class SrWarranty
    {
        public SrWarranty()
        {
            SrVehicles = new HashSet<SrVehicle>();
        }

        [Key]
        [Column("WId")]
        public int Wid { get; set; }
        [Column("WCode")]
        [StringLength(50)]
        public string? Wcode { get; set; }
        [Column("WName1")]
        [StringLength(100)]
        public string? Wname1 { get; set; }
        [Column("WName2")]
        [StringLength(100)]
        public string? Wname2 { get; set; }
        [Column("WConditions")]
        [StringLength(1000)]
        public string? Wconditions { get; set; }
        /// <summary>
        /// 0 periodic,1 distance, 2 both
        /// </summary>
        [Column("WMethod")]
        public byte? Wmethod { get; set; }
        [Column("WPeriodMonths")]
        public int? WperiodMonths { get; set; }
        [Column("WDistance")]
        public int? Wdistance { get; set; }
        [Column("WUse")]
        public bool? Wuse { get; set; }
        public bool? Exemption { get; set; }
        public byte? ExemptionPercnt { get; set; }
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

        [InverseProperty("WidNavigation")]
        public virtual ICollection<SrVehicle> SrVehicles { get; set; }
    }
}
