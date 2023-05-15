using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cod_UnitServices")]
    public partial class CodUnitService
    {
        public CodUnitService()
        {
            ProjProjUnitServices = new HashSet<ProjProjUnitService>();
        }

        [Key]
        public int UnitServId { get; set; }
        public int Code { get; set; }
        [StringLength(100)]
        public string? DescA { get; set; }
        [StringLength(100)]
        public string? DescE { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
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
        [StringLength(100)]
        public string? RemarksA { get; set; }
        [StringLength(100)]
        public string? RemarksE { get; set; }

        [InverseProperty("UnitServ")]
        public virtual ICollection<ProjProjUnitService> ProjProjUnitServices { get; set; }
    }
}
