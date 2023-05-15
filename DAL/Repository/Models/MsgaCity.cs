using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MSGA_City")]
    public partial class MsgaCity
    {
        public MsgaCity()
        {
            SrExtensions = new HashSet<SrExtension>();
            SrHotels = new HashSet<SrHotel>();
        }

        [Key]
        [Column("CityID")]
        public int CityId { get; set; }
        [StringLength(50)]
        public string? CityCode { get; set; }
        [StringLength(100)]
        public string? CityName { get; set; }
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
        public string? Remarks { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
        [Column("SysCityID")]
        public int? SysCityId { get; set; }
        public int? CountryId { get; set; }

        [InverseProperty("City")]
        public virtual ICollection<SrExtension> SrExtensions { get; set; }
        [InverseProperty("City")]
        public virtual ICollection<SrHotel> SrHotels { get; set; }
    }
}
