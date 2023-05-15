using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sys_City")]
    public partial class SysCity
    {
        public SysCity()
        {
            CodCities = new HashSet<CodCity>();
        }

        [Key]
        [Column("SysCityID")]
        public int SysCityId { get; set; }
        [Column("cityName")]
        [StringLength(100)]
        public string? CityName { get; set; }
        [StringLength(50)]
        public string? CountryCode { get; set; }
        [Column("latitude")]
        [StringLength(100)]
        public string? Latitude { get; set; }
        [Column("longitude")]
        [StringLength(100)]
        public string? Longitude { get; set; }

        [InverseProperty("SysCity")]
        public virtual ICollection<CodCity> CodCities { get; set; }
    }
}
