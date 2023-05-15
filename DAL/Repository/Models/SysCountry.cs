using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sys_Countries")]
    public partial class SysCountry
    {
        public SysCountry()
        {
            CodCountries = new HashSet<CodCountry>();
        }

        public int CountryId { get; set; }
        [Key]
        [StringLength(50)]
        public string CountryCode { get; set; } = null!;
        [StringLength(100)]
        public string? CountryName { get; set; }
        [Column("latitude")]
        [StringLength(100)]
        public string? Latitude { get; set; }
        [Column("longitude")]
        [StringLength(100)]
        public string? Longitude { get; set; }

        [InverseProperty("CountryCodeNavigation")]
        public virtual ICollection<CodCountry> CodCountries { get; set; }
    }
}
