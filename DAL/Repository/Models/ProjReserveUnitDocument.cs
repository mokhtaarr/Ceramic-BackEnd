using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ReserveUnitDocuments")]
    [Index("Fsid", Name = "UQ__Proj_Res__9C4B0717908FFF11", IsUnique = true)]
    public partial class ProjReserveUnitDocument
    {
        [Key]
        public int ReservDocId { get; set; }
        public int? ReservId { get; set; }
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

        [ForeignKey("ReservId")]
        [InverseProperty("ProjReserveUnitDocuments")]
        public virtual ProjUnitReservation? Reserv { get; set; }
    }
}
