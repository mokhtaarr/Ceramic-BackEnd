using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Proj_ReserveUnitSellers")]
    public partial class ProjReserveUnitSeller
    {
        [Key]
        public int ReservSellerId { get; set; }
        public int? ReservId { get; set; }
        public int? ResourceId { get; set; }
        public bool? IsMainOwner { get; set; }
        public byte? ResourceType { get; set; }
        public int? ResourceAccountId { get; set; }
        public int? HelpAccId { get; set; }
        [StringLength(50)]
        public string? HelpAccType { get; set; }
        [StringLength(100)]
        public string? AccountDescription { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? ShareValue { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SharePercent { get; set; }
        [StringLength(200)]
        public string? Remarks1 { get; set; }
        [StringLength(200)]
        public string? Remarks2 { get; set; }

        [ForeignKey("ReservId")]
        [InverseProperty("ProjReserveUnitSellers")]
        public virtual ProjUnitReservation? Reserv { get; set; }
    }
}
