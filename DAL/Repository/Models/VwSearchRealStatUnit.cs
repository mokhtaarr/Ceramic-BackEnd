using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwSearchRealStatUnit
    {
        [StringLength(100)]
        public string? Code { get; set; }
        [StringLength(200)]
        public string? Name1 { get; set; }
        [StringLength(200)]
        public string? Name2 { get; set; }
        public int? FloorNumber { get; set; }
        public int? RoomCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitArea { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? UnitMeterPrice { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TotalPrice { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpectedDeliveryDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryDate { get; set; }
        public bool? Sold { get; set; }
        public bool? Reserved { get; set; }
        [StringLength(50)]
        public string? ContractDocNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ContractDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReserveDate { get; set; }
        public bool? Rented { get; set; }
        [StringLength(50)]
        public string? RentDocNo { get; set; }
        public int? ResourceId { get; set; }
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
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        [StringLength(100)]
        public string? CustomerDescE { get; set; }
        [Column("cc")]
        public int Cc { get; set; }
    }
}
