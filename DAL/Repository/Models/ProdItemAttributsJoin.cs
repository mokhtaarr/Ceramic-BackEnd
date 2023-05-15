using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_ItemAttributsJoin")]
    public partial class ProdItemAttributsJoin
    {
        [Key]
        public int ProdItemAtrribId { get; set; }
        public int? ItemCardId { get; set; }
        public int? AttributId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsMandatory { get; set; }
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

        [ForeignKey("AttributId")]
        [InverseProperty("ProdItemAttributsJoins")]
        public virtual ProdItemAttribute? Attribut { get; set; }
        [ForeignKey("ItemCardId")]
        [InverseProperty("ProdItemAttributsJoins")]
        public virtual MsItemCard? ItemCard { get; set; }
    }
}
