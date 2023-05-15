using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_ItemCategory")]
    public partial class MsItemCategory
    {
        public MsItemCategory()
        {
            MsItemCards = new HashSet<MsItemCard>();
        }

        [Key]
        public int ItemCategoryId { get; set; }
        [StringLength(50)]
        public string ItemCatCode { get; set; } = null!;
        [StringLength(100)]
        public string? ItemCatDescA { get; set; }
        [StringLength(100)]
        public string? ItemCatDescE { get; set; }
        public int? ParentItemCategoryId { get; set; }
        public byte? ItemCategoryType { get; set; }
        public int? ItemCategoryCatLevel { get; set; }
        [Column(TypeName = "image")]
        public byte[]? CategoryImage { get; set; }
        public int? CurrentTrNo { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }

        [InverseProperty("ItemCategory")]
        public virtual ICollection<MsItemCard> MsItemCards { get; set; }
    }
}
