using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cod_OwnershipBonds")]
    public partial class CodOwnershipBond
    {
        public CodOwnershipBond()
        {
            ProjProjDocuments = new HashSet<ProjProjDocument>();
            ProjProjUnitDocuments = new HashSet<ProjProjUnitDocument>();
        }

        [Key]
        public int OwnShipBondId { get; set; }
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
        [StringLength(255)]
        public string? RemarksA { get; set; }
        [StringLength(255)]
        public string? RemarksE { get; set; }

        [InverseProperty("OwnShipBond")]
        public virtual ICollection<ProjProjDocument> ProjProjDocuments { get; set; }
        [InverseProperty("OwnShipBond")]
        public virtual ICollection<ProjProjUnitDocument> ProjProjUnitDocuments { get; set; }
    }
}
