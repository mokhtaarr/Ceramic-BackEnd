using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cod_Region")]
    public partial class CodRegion
    {
        public CodRegion()
        {
            CodCities = new HashSet<CodCity>();
        }

        [Key]
        public int RegionId { get; set; }
        public int Code { get; set; }
        [StringLength(100)]
        public string? NameA { get; set; }
        [StringLength(100)]
        public string? NameE { get; set; }
        [StringLength(255)]
        public string? RemarksA { get; set; }
        [StringLength(255)]
        public string? RemarksE { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? CountryId { get; set; }
        [StringLength(100)]
        public string? Lat { get; set; }
        [StringLength(100)]
        public string? Lng { get; set; }
        public byte? MinZoom { get; set; }
        public byte? MaxZoom { get; set; }
        public byte? CurrentZoom { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("CountryId")]
        [InverseProperty("CodRegions")]
        public virtual CodCountry? Country { get; set; }
        [InverseProperty("Region")]
        public virtual ICollection<CodCity> CodCities { get; set; }
    }
}
