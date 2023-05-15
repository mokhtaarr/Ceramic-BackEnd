using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ProjUnitDocument")]
    [Index("Fsid", Name = "UQ__Proj_Pro__9C4B07170092463A", IsUnique = true)]
    public partial class ProjProjUnitDocument
    {
        [Key]
        public int ProjUnitDocumentId { get; set; }
        public int? ProjUnitId { get; set; }
        [Column("FSId")]
        public Guid Fsid { get; set; }
        public int? OwnShipBondId { get; set; }
        public int? ShelvId { get; set; }
        [StringLength(50)]
        public string? PaperNo { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public long? AttachSerial { get; set; }
        [StringLength(1000)]
        public string? SearchTags { get; set; }
        public string? AttachPath { get; set; }
        [Column("FData")]
        public byte[]? Fdata { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? IssueDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpiryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RenewalDate { get; set; }
        [StringLength(100)]
        public string? IssuePlace { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("OwnShipBondId")]
        [InverseProperty("ProjProjUnitDocuments")]
        public virtual CodOwnershipBond? OwnShipBond { get; set; }
        [ForeignKey("ProjUnitId")]
        [InverseProperty("ProjProjUnitDocuments")]
        public virtual ProjProjUnit? ProjUnit { get; set; }
    }
}
