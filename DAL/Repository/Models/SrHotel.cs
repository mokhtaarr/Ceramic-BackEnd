using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_Hotels")]
    public partial class SrHotel
    {
        public SrHotel()
        {
            SrAccomodations = new HashSet<SrAccomodation>();
            SrExtensions = new HashSet<SrExtension>();
        }

        [Key]
        public int HotelId { get; set; }
        [StringLength(50)]
        public string? HotelCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        public byte? Stars { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        public int? ElevatorNum { get; set; }
        public int? RoomSingleCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RoomSingleCost { get; set; }
        public int? DoubleRoomCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DoubleRoomCost { get; set; }
        public int? TribleRoomCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TribleRoomCost { get; set; }
        public int? QuadRoomCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? QuadRoomCost { get; set; }
        public int? SuitRoomCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SuitRoomCost { get; set; }
        public int? SpecialRoomCount { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? SpecialRoomCost { get; set; }
        [Column("SupportFB")]
        public bool? SupportFb { get; set; }
        [Column("SupportHB")]
        public bool? SupportHb { get; set; }
        [Column("SupportBB")]
        public bool? SupportBb { get; set; }
        [Column("SupportRO")]
        public bool? SupportRo { get; set; }
        [Column("RoomsWithWC")]
        public bool? RoomsWithWc { get; set; }
        [Column("FBCost", TypeName = "numeric(38, 10)")]
        public decimal? Fbcost { get; set; }
        [Column("HBCost", TypeName = "numeric(38, 10)")]
        public decimal? Hbcost { get; set; }
        [Column("BBCost", TypeName = "numeric(38, 10)")]
        public decimal? Bbcost { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(20)]
        public string? Fax { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Email2 { get; set; }
        [StringLength(50)]
        public string? Email3 { get; set; }
        [StringLength(50)]
        public string? Email4 { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        [StringLength(200)]
        public string? Address1 { get; set; }
        [StringLength(200)]
        public string? Address2 { get; set; }
        [StringLength(200)]
        public string? Address3 { get; set; }
        [StringLength(20)]
        public string? Tel2 { get; set; }
        [StringLength(20)]
        public string? Tel3 { get; set; }
        [StringLength(20)]
        public string? Tel4 { get; set; }
        [StringLength(20)]
        public string? Tel5 { get; set; }
        [StringLength(255)]
        public string? AddField1 { get; set; }
        [StringLength(255)]
        public string? AddField2 { get; set; }
        [StringLength(255)]
        public string? AddField3 { get; set; }
        [StringLength(255)]
        public string? AddField4 { get; set; }
        [StringLength(255)]
        public string? AddField5 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("CityId")]
        [InverseProperty("SrHotels")]
        public virtual MsgaCity? City { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<SrAccomodation> SrAccomodations { get; set; }
        [InverseProperty("Hotel")]
        public virtual ICollection<SrExtension> SrExtensions { get; set; }
    }
}
