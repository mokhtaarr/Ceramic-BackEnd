using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_ContainerTypes")]
    public partial class SrContainerType
    {
        public SrContainerType()
        {
            SrTrafficLinePriceLists = new HashSet<SrTrafficLinePriceList>();
        }

        [Key]
        public int ContainerTypeId { get; set; }
        public int? VehicleShapeId { get; set; }
        public int? VehicleTypId { get; set; }
        [StringLength(50)]
        public string? ContainerCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Weight { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Length { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Width { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Height { get; set; }
        [StringLength(1000)]
        public string? UseDesc { get; set; }
        [StringLength(254)]
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

        [InverseProperty("ContainerType")]
        public virtual ICollection<SrTrafficLinePriceList> SrTrafficLinePriceLists { get; set; }
    }
}
