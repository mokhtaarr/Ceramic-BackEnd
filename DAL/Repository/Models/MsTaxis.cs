using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_Taxes")]
    public partial class MsTaxis
    {
        public MsTaxis()
        {
            MsPurchasInvoices = new HashSet<MsPurchasInvoice>();
        }

        [Key]
        public int TaxesId { get; set; }
        [StringLength(50)]
        public string? TaxCode { get; set; }
        [StringLength(100)]
        public string? TaxNameA { get; set; }
        [StringLength(100)]
        public string? TaxNameE { get; set; }
        /// <summary>
        /// 0 Percent , 1 value , 2 Without
        /// </summary>
        public byte? TaxStyle { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TaxRate { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        public int? AccountId { get; set; }
        public bool? IsAccomulative { get; set; }
        public bool? PlusOrMinus { get; set; }
        [StringLength(50)]
        public string? EtaxCode { get; set; }
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

        [InverseProperty("TaxesId1Navigation")]
        public virtual ICollection<MsPurchasInvoice> MsPurchasInvoices { get; set; }
    }
}
