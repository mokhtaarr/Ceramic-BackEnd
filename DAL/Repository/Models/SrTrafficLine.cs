using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_TrafficLines")]
    public partial class SrTrafficLine
    {
        public SrTrafficLine()
        {
            SrTrafficLinePriceLists = new HashSet<SrTrafficLinePriceList>();
        }

        [Key]
        public int TrafficLineId { get; set; }
        [StringLength(50)]
        public string? TrafficCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(100)]
        public string? TrafficFrom { get; set; }
        [StringLength(100)]
        public string? TrafficTo { get; set; }
        [Column("CityIDFrom")]
        public int? CityIdfrom { get; set; }
        [Column("CityIDTo")]
        public int? CityIdto { get; set; }
        public int? FromHarborId { get; set; }
        public int? ToHarborId { get; set; }
        [Column("KM", TypeName = "numeric(38, 10)")]
        public decimal? Km { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Price { get; set; }
        public bool? PricebyContainer { get; set; }
        public bool? PricebyVehicl { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EstimatCost { get; set; }
        public bool? CostbyContainer { get; set; }
        public bool? CostbyVehicl { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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

        [InverseProperty("TrafficLine")]
        public virtual ICollection<SrTrafficLinePriceList> SrTrafficLinePriceLists { get; set; }
    }
}
