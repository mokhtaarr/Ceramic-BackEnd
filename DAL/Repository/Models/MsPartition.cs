using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_Partition")]
    public partial class MsPartition
    {
        public MsPartition()
        {
            MsItemPartitions = new HashSet<MsItemPartition>();
        }

        [Key]
        public int StorePartId { get; set; }
        public int? StoreId { get; set; }
        [StringLength(50)]
        public string PartCode { get; set; } = null!;
        [StringLength(100)]
        public string? PartDescA { get; set; }
        [StringLength(50)]
        public string? PartDescE { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [StringLength(50)]
        public string? StoreKeeper { get; set; }
        [StringLength(20)]
        public string? Tel { get; set; }
        [StringLength(100)]
        public string? Address { get; set; }
        [StringLength(20)]
        public string? Fax { get; set; }
        [Column("strCustm2")]
        [StringLength(20)]
        public string? StrCustm2 { get; set; }
        [Column("strCustm3")]
        [StringLength(20)]
        public string? StrCustm3 { get; set; }
        [Column("strCustm4")]
        [StringLength(20)]
        public string? StrCustm4 { get; set; }
        [Column("strCustm5")]
        [StringLength(20)]
        public string? StrCustm5 { get; set; }
        [Column("strCustm6")]
        [StringLength(20)]
        public string? StrCustm6 { get; set; }
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
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? X { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Y { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Z { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Space { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Size { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? AnimalCount { get; set; }
        public bool? IsAnimalStore { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        public bool? SharedPartition { get; set; }

        [ForeignKey("StoreId")]
        [InverseProperty("MsPartitions")]
        public virtual MsStore? Store { get; set; }
        [InverseProperty("StorePart")]
        public virtual ICollection<MsItemPartition> MsItemPartitions { get; set; }
    }
}
