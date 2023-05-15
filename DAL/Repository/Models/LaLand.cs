using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("La_Lands")]
    public partial class LaLand
    {
        [Key]
        public int LandId { get; set; }
        public int? CustomerId { get; set; }
        public int? LandMainNo { get; set; }
        public int? LandInternalNo { get; set; }
        public int? StreetNo { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? LandSize { get; set; }
        public bool? IsResidential { get; set; }
        public bool? RightLeft { get; set; }
        [StringLength(100)]
        public string? BasicMemeber { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("LaLands")]
        public virtual MsCustomer? Customer { get; set; }
    }
}
